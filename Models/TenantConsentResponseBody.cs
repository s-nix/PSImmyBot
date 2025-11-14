using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantConsentResponseBody(
    [property: JsonPropertyName("isPartner")]
    bool IsPartner,
    [property: JsonPropertyName("tenantPrincipalId")]
    string? TenantPrincipalId);
