using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TargetAssignmentVisibilityPayload(
    [property: JsonPropertyName("selfService")]
    bool SelfService,
    [property: JsonPropertyName("technicianPod")]
    bool TechnicianPod);
