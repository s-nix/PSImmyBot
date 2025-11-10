using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SetParentTenantRequest(
    [property: JsonPropertyName("parentTenantId")]
    int ParentTenantId,
    [property: JsonPropertyName("tenantIds")]
    ICollection<int>? TenantIds);
