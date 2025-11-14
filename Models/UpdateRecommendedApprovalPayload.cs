using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateRecommendedApprovalPayload(
    [property: JsonPropertyName("approved")]
    bool Approved,
    [property: JsonPropertyName("globalTargetAssignmentId")]
    int GlobalTargetAssignmentId);
