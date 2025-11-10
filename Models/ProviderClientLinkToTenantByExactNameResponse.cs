using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderClientLinkToTenantByExactNameResponse(
    [property: JsonPropertyName("externalClientId")]
    string? ExternalClientId,
    [property: JsonPropertyName("linkedToTenantId")]
    int? LinkedToTenantId);
