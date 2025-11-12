using System.Text.Json;
using PSImmyBot.Models;

namespace PSImmyBot.Services;

public static class ImmyBotApiService {
    public static async Task<T> Get<T>(string endpoint) {
        AzureTokenResponse token = Globals.Token
            ?? throw new InvalidOperationException("Azure token is not available or expired. Please authenticate first with Connect-ImmyApi.");
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri($"https://{Globals.GetApiConnectionConfig().ImmySubdomain}.immy.bot");
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
        HttpResponseMessage response = await client.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();
        // If the content-type is not Json return the raw content
        if (!response.Content.Headers.ContentType?.MediaType?.Contains("json") ?? false) {
            object rawContent = await response.Content.ReadAsByteArrayAsync();
            return (T)rawContent;
        }
        string responseContent = await response.Content.ReadAsStringAsync();
        T? result;
        try {
            result = JsonSerializer.Deserialize<T>(responseContent);
        } catch (JsonException) {
            using JsonDocument doc = JsonDocument.Parse(responseContent);
            if (doc.RootElement.TryGetProperty("data", out JsonElement value)) {
                result = JsonSerializer.Deserialize<T>(value.GetRawText());
            } else {
                throw;
            }
        }
        return result ?? throw new JsonException("Failed to deserialize API response.");
    }

    public static async Task Post(string endpoint) {
        AzureTokenResponse token = Globals.Token
            ?? throw new InvalidOperationException("Azure token is not available or expired. Please authenticate first with Connect-ImmyApi.");
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri($"https://{Globals.GetApiConnectionConfig().ImmySubdomain}.immy.bot");
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
        HttpResponseMessage response = await client.PostAsync(endpoint, null);
        response.EnsureSuccessStatusCode();
    }
    
    public static async Task Post<T>(string endpoint, T? bodyObject) {
        AzureTokenResponse token = Globals.Token
            ?? throw new InvalidOperationException("Azure token is not available or expired. Please authenticate first with Connect-ImmyApi.");
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri($"https://{Globals.GetApiConnectionConfig().ImmySubdomain}.immy.bot");
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
        StringContent? content = null;
        if (bodyObject != null) {
            string bodyJson = JsonSerializer.Serialize(bodyObject);
            content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
        }
        HttpResponseMessage response = await client.PostAsync(endpoint, content);
        response.EnsureSuccessStatusCode();
        string responseContent = await response.Content.ReadAsStringAsync();
    }
    
    public static async Task<T> Post<T>(string endpoint) {
        AzureTokenResponse token = Globals.Token
            ?? throw new InvalidOperationException("Azure token is not available or expired. Please authenticate first with Connect-ImmyApi.");
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri($"https://{Globals.GetApiConnectionConfig().ImmySubdomain}.immy.bot");
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
        HttpResponseMessage response = await client.PostAsync(endpoint, null);
        response.EnsureSuccessStatusCode();
        string responseContent = await response.Content.ReadAsStringAsync();
        T? result;
        try {
            result = JsonSerializer.Deserialize<T>(responseContent);
        } catch (JsonException) {
            using JsonDocument doc = JsonDocument.Parse(responseContent);
            if (doc.RootElement.TryGetProperty("data", out JsonElement value)) {
                result = JsonSerializer.Deserialize<T>(value.GetRawText());
            } else {
                throw;
            }
        }
        return result ?? throw new JsonException("Failed to deserialize API response.");
    }
    
    public static async Task<U?> Post<T, U>(string endpoint, T? bodyObject) {
        AzureTokenResponse token = Globals.Token
            ?? throw new InvalidOperationException("Azure token is not available or expired. Please authenticate first with Connect-ImmyApi.");
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri($"https://{Globals.GetApiConnectionConfig().ImmySubdomain}.immy.bot");
        client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
        StringContent? content = null;
        if (bodyObject != null) {
            string bodyJson = JsonSerializer.Serialize(bodyObject);
            content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
        }
        HttpResponseMessage response = await client.PostAsync(endpoint, content);
        response.EnsureSuccessStatusCode();
        string responseContent = await response.Content.ReadAsStringAsync();
        U? result;
        try {
            result = JsonSerializer.Deserialize<U>(responseContent);
        } catch (JsonException) {
            using JsonDocument doc = JsonDocument.Parse(responseContent);
            if (doc.RootElement.TryGetProperty("data", out JsonElement value)) {
                result = JsonSerializer.Deserialize<U>(value.GetRawText());
            } else {
                throw;
            }
        }
        return result ?? throw new JsonException("Failed to deserialize API response.");
    }
}
