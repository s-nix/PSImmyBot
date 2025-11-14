using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record AzureTokenResponse {
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = default!;

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    [JsonPropertyName("ext_expires_in")]
    public int ExtExpiresIn { get; set; }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = default!;

    public DateTime CreationTime { get; set; } = DateTime.UtcNow;

    [JsonIgnore]
    public DateTime ExpirationTime => CreationTime.AddSeconds(ExpiresIn);
}
