using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DisambiguateAzureTenantTypeRequestBody(
    [property: JsonPropertyName("tenantPrincipalId")]
    string? TenantPrincipalId);
