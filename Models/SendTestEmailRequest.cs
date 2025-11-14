using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SendTestEmailRequest(
    [property: JsonPropertyName("enabled")]
    bool Enabled,
    [property: JsonPropertyName("enableSSL")]
    bool EnableSsl,
    [property: JsonPropertyName("from")] string? From,
    [property: JsonPropertyName("host")] string? Host,
    [property: JsonPropertyName("password")]
    string? Password,
    [property: JsonPropertyName("port")] int Port,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("timeout")]
    int Timeout,
    [property: JsonPropertyName("to")] string? To,
    [property: JsonPropertyName("useAuthentication")]
    bool UseAuthentication,
    [property: JsonPropertyName("username")]
    string? Username);
