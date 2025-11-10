using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BatchUpdateAssignmentRequest(
    [property: JsonPropertyName("targetAssignmentIds")]
    ICollection<int>? TargetAssignmentIds,
    [property: JsonPropertyName("updateArray")]
    ICollection<UpdateTargetVisibilityPayload>? UpdateArray);
