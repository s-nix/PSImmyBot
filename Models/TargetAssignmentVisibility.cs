using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TargetAssignmentVisibility(
    [property: JsonPropertyName("selfService")]
    bool SelfService,
    [property: JsonPropertyName("targetAssignment")]
    TargetAssignment TargetAssignment,
    [property: JsonPropertyName("targetAssignmentId")]
    int TargetAssignmentId,
    [property: JsonPropertyName("technicianPod")]
    bool TechnicianPod);
