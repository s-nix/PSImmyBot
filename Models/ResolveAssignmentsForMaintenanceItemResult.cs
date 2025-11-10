using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ResolveAssignmentsForMaintenanceItemResult(
    [property: JsonPropertyName("computers")]
    ICollection<ComputerDto>? Computers,
    [property: JsonPropertyName("items")] ICollection<ResolveAssignmentsForMaintenanceItemResultItem>? Items);
