using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MergeTenantsPayload(
    [property: JsonPropertyName("targetTenantId")]
    int TargetTenantId,
    [property: JsonPropertyName("tenantsToMerge")]
    ICollection<int>? TenantsToMerge);
