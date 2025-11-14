using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MissingAccessTokenDetails(
    [property: JsonPropertyName("requiredScopes")]
    string? RequiredScopes,
    [property: JsonPropertyName("tenantId")]
    string? TenantId);
