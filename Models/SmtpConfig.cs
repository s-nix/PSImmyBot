using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SmtpConfig(
    [property: JsonPropertyName("enabled")]
    bool Enabled,
    [property: JsonPropertyName("enableSSL")]
    bool EnableSsl,
    [property: JsonPropertyName("host")] string? Host,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("passwordHash")]
    string? PasswordHash,
    [property: JsonPropertyName("port")] int Port,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("timeout")]
    int Timeout,
    [property: JsonPropertyName("useAuthentication")]
    bool UseAuthentication,
    [property: JsonPropertyName("username")]
    string? Username);
