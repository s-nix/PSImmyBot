using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TargetAssignmentDuplicateResponse(
    [property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("duplicateIds")]
    ICollection<int>? DuplicateIds);
