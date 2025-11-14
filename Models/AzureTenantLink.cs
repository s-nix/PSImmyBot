using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantLink(
    [property: JsonPropertyName("azTenantId")]
    string? AzTenantId,
    [property: JsonPropertyName("azureTenant")]
    AzureTenant AzureTenant,
    [property: JsonPropertyName("immyTenantId")]
    int ImmyTenantId,
    [property: JsonPropertyName("limitToDomains")]
    ICollection<AzureTenantLinkDomainFilter>? LimitToDomains,
    [property: JsonPropertyName("shouldLimitDomains")]
    bool ShouldLimitDomains,
    [property: JsonPropertyName("tenant")] Tenant Tenant);
