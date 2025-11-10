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
        string responseContent = await response.Content.ReadAsStringAsync();
        T? result = System.Text.Json.JsonSerializer.Deserialize<T>(responseContent);
        return result ?? throw new System.Text.Json.JsonException("Failed to deserialize API response.");
    }
}
