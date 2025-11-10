using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantSoftware(
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("software")]
    LocalSoftware Software,
    [property: JsonPropertyName("softwareId")]
    int SoftwareId,
    [property: JsonPropertyName("tenant")] Tenant Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
