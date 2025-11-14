using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CheckTenantPartnerStatusResponseBody(
    [property: JsonPropertyName("azureTenantType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AzTenantType>))]
    AzTenantType AzureTenantType,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId,
    [property: JsonPropertyName("tenantPrincipalId")]
    string? TenantPrincipalId);
