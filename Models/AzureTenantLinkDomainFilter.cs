using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantLinkDomainFilter(
    [property: JsonPropertyName("azTenantId")]
    string? AzTenantId,
    [property: JsonPropertyName("domainName")]
    string? DomainName,
    [property: JsonPropertyName("immyTenantId")]
    int ImmyTenantId);
