using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetSmtpConfigResponse(
    [property: JsonPropertyName("enabled")]
    bool Enabled,
    [property: JsonPropertyName("enableSSL")]
    bool EnableSsl,
    [property: JsonPropertyName("host")] string? Host,
    [property: JsonPropertyName("port")] int Port,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("timeout")]
    int Timeout,
    [property: JsonPropertyName("useAuthentication")]
    bool UseAuthentication,
    [property: JsonPropertyName("username")]
    string? Username);
