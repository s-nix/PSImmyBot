using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using PSImmyBot.Models;

namespace PSImmyBot.Services;

public static class ImmyBotApiService
{
    private static readonly JsonSerializerOptions serializerOptions = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    internal static Func<ApiRequestContext, object?>? TestResponder { get; set; }

    public static Task<T> Get<T>(string endpoint) => SendAsync<T>(HttpMethod.Get, endpoint, null, null);

    public static Task Post(string endpoint) => SendAsync(HttpMethod.Post, endpoint, null, null);

    public static Task Post<T>(string endpoint, T? bodyObject) =>
        SendAsync(HttpMethod.Post, endpoint, CreateJsonContent(bodyObject), bodyObject);

    public static Task<T> Post<T>(string endpoint) => SendAsync<T>(HttpMethod.Post, endpoint, null, null);

    public static Task<U> Post<T, U>(string endpoint, T? bodyObject) =>
        SendAsync<U>(HttpMethod.Post, endpoint, CreateJsonContent(bodyObject), bodyObject);

    public static Task Patch(string endpoint) => SendAsync(HttpMethod.Patch, endpoint, null, null);

    public static Task Patch<T>(string endpoint, T? bodyObject) =>
        SendAsync(HttpMethod.Patch, endpoint, CreateJsonContent(bodyObject), bodyObject);

    public static Task<T> Patch<T>(string endpoint) => SendAsync<T>(HttpMethod.Patch, endpoint, null, null);

    public static Task<U> Patch<T, U>(string endpoint, T? bodyObject) =>
        SendAsync<U>(HttpMethod.Patch, endpoint, CreateJsonContent(bodyObject), bodyObject);

    public static Task Put(string endpoint) => SendAsync(HttpMethod.Put, endpoint, null, null);

    public static Task Put<T>(string endpoint, T? bodyObject) =>
        SendAsync(HttpMethod.Put, endpoint, CreateJsonContent(bodyObject), bodyObject);

    public static Task<T> Put<T>(string endpoint) => SendAsync<T>(HttpMethod.Put, endpoint, null, null);

    public static Task<U> Put<T, U>(string endpoint, T? bodyObject) =>
        SendAsync<U>(HttpMethod.Put, endpoint, CreateJsonContent(bodyObject), bodyObject);

    public static Task Delete(string endpoint) => SendAsync(HttpMethod.Delete, endpoint, null, null);

    public static Task<T> Delete<T>(string endpoint) => SendAsync<T>(HttpMethod.Delete, endpoint, null, null);

    private static async Task SendAsync(HttpMethod method, string endpoint, HttpContent? content, object? bodyObject)
    {
        ApiRequestContext context = new(method, NormalizeEndpoint(endpoint), bodyObject, null);
        if (TestResponder is { } responder)
        {
            _ = responder(context);
            return;
        }

        using HttpResponseMessage response = await SendHttpRequestAsync(method, context.Endpoint, content);
        response.EnsureSuccessStatusCode();
    }

    private static async Task<T> SendAsync<T>(HttpMethod method, string endpoint, HttpContent? content, object? bodyObject)
    {
        ApiRequestContext context = new(method, NormalizeEndpoint(endpoint), bodyObject, typeof(T));
        if (TestResponder is { } responder)
        {
            object? stubbed = responder(context);
            if (stubbed is T typed)
            {
                return typed;
            }
            return (T)(stubbed ?? CreateDefaultResponse(typeof(T))!);
        }

        using HttpResponseMessage response = await SendHttpRequestAsync(method, context.Endpoint, content);
        return await ReadResponseContentAsync<T>(response);
    }

    private static async Task<HttpResponseMessage> SendHttpRequestAsync(HttpMethod method, string endpoint, HttpContent? content)
    {
        AzureTokenResponse token = Globals.Token
            ?? throw new InvalidOperationException("Azure token is not available or expired. Please authenticate first with Connect-ImmyApi.");
        ApiConnectionConfig config = Globals.GetApiConnectionConfig();
        HttpClient client = new()
        {
            BaseAddress = new Uri($"https://{config.ImmySubdomain}.immy.bot")
        };
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        HttpRequestMessage request = new(method, endpoint)
        {
            Content = content
        };
        HttpResponseMessage response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        return response;
    }

    private static async Task<T> ReadResponseContentAsync<T>(HttpResponseMessage response)
    {
        if (!IsJsonResponse(response))
        {
            object rawContent = await response.Content.ReadAsByteArrayAsync();
            return (T)rawContent;
        }

        string responseContent = await response.Content.ReadAsStringAsync();
        T? result;
        try
        {
            result = JsonSerializer.Deserialize<T>(responseContent, serializerOptions);
        }
        catch (JsonException)
        {
            using JsonDocument doc = JsonDocument.Parse(responseContent);
            if (doc.RootElement.TryGetProperty("data", out JsonElement value))
            {
                result = JsonSerializer.Deserialize<T>(value.GetRawText(), serializerOptions);
            }
            else
            {
                throw;
            }
        }
        return result ?? throw new JsonException("Failed to deserialize API response.");
    }

    private static bool IsJsonResponse(HttpResponseMessage response) =>
        response.Content.Headers.ContentType?.MediaType?.Contains("json", StringComparison.OrdinalIgnoreCase) ?? false;

    private static HttpContent? CreateJsonContent<T>(T? bodyObject)
    {
        if (bodyObject == null)
        {
            return null;
        }

        string bodyJson = JsonSerializer.Serialize(bodyObject);
        return new StringContent(bodyJson, Encoding.UTF8, "application/json");
    }

    private static string NormalizeEndpoint(string endpoint)
    {
        if (string.IsNullOrWhiteSpace(endpoint))
        {
            return "/";
        }
        return endpoint.StartsWith('/') ? endpoint : $"/{endpoint}";
    }

    private static object? CreateDefaultResponse(System.Type type)
    {
        if (type == typeof(byte[]))
        {
            return Array.Empty<byte>();
        }

        if (type == typeof(string))
        {
            return string.Empty;
        }

        if (type == typeof(JsonDocument))
        {
            return JsonDocument.Parse("{}");
        }

        if (type == typeof(object))
        {
            return new object();
        }

        System.Type? underlying = Nullable.GetUnderlyingType(type);
        if (underlying != null)
        {
            return CreateDefaultResponse(underlying);
        }

        if (type.IsArray)
        {
            System.Type elementType = type.GetElementType()!;
            return Array.CreateInstance(elementType, 0);
        }

        if (type.IsGenericType)
        {
            System.Type genericType = type.GetGenericTypeDefinition();
            if (genericType == typeof(IEnumerable<>) || genericType == typeof(ICollection<>) || genericType == typeof(IList<>) ||
                genericType == typeof(IReadOnlyCollection<>) || genericType == typeof(IReadOnlyList<>))
            {
                System.Type listType = typeof(List<>).MakeGenericType(type.GetGenericArguments()[0]);
                return Activator.CreateInstance(listType);
            }

            if (genericType == typeof(IDictionary<,>) || genericType == typeof(IReadOnlyDictionary<,>))
            {
                System.Type dictType = typeof(Dictionary<,>).MakeGenericType(type.GetGenericArguments());
                return Activator.CreateInstance(dictType);
            }
        }

        if (type.IsEnum)
        {
            Array values = Enum.GetValues(type);
            return values.Length > 0 ? values.GetValue(0) : Activator.CreateInstance(type);
        }

        if (type.IsValueType)
        {
            return Activator.CreateInstance(type);
        }

        System.Reflection.ConstructorInfo? parameterlessCtor = type.GetConstructor(System.Type.EmptyTypes);
        if (parameterlessCtor != null)
        {
            return parameterlessCtor.Invoke(null);
        }

        return RuntimeHelpers.GetUninitializedObject(type);
    }

    internal sealed record ApiRequestContext(HttpMethod Method, string Endpoint, object? Body, System.Type? ResponseType);
}
