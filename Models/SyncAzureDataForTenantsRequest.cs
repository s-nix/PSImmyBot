using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SyncAzureDataForTenantsRequest(
    [property: JsonPropertyName("allPartnerTenants")]
    bool AllPartnerTenants,
    [property: JsonPropertyName("tenantPrincipalIds")]
    ICollection<string>? TenantPrincipalIds);
