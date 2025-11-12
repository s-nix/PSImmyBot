using System.Text.Json;
using PSImmyBot.Models;

namespace PSImmyBot.Services;

public static class ImmyBotApiService {
    public static async Task<T> Get<T>(string endpoint) {
        AzureTokenResponse token = Globals.Token
            ?? throw new InvalidOperationException("API token is not available.");
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
        return result ?? throw new System.Text.Json.JsonException("Failed to deserialize API response.");
    }
}
