using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantLinkResponse(
    [property: JsonPropertyName("azTenantId")]
    string? AzTenantId,
    [property: JsonPropertyName("azureTenant")]
    AzureTenantResponse AzureTenant,
    [property: JsonPropertyName("immyTenantId")]
    int ImmyTenantId,
    [property: JsonPropertyName("limitToDomains")]
    ICollection<AzureTenantLinkDomainFilter>? LimitToDomains,
    [property: JsonPropertyName("shouldLimitDomains")]
    bool ShouldLimitDomains);
