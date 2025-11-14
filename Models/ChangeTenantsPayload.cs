using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChangeTenantsPayload(
    [property: JsonPropertyName("computersToMove")]
    ICollection<int>? ComputersToMove,
    [property: JsonPropertyName("targetTenantId")]
    int TargetTenantId);
