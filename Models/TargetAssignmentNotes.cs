using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TargetAssignmentNotes(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("notes")] string? Notes,
    [property: JsonPropertyName("targetAssignment")]
    TargetAssignment TargetAssignment,
    [property: JsonPropertyName("targetAssignmentId")]
    int TargetAssignmentId,
    [property: JsonPropertyName("updatedByName")]
    string? UpdatedByName,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
