using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TargetAssignmentVisibilityResource(
    [property: JsonPropertyName("selfService")]
    bool SelfService,
    [property: JsonPropertyName("technicianPod")]
    bool TechnicianPod);
