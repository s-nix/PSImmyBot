using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetRecommendedApprovalResponse(
    [property: JsonPropertyName("approved")]
    bool Approved,
    [property: JsonPropertyName("createdBy")]
    string? CreatedBy,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("globalTargetAssignmentId")]
    int GlobalTargetAssignmentId,
    [property: JsonPropertyName("updatedBy")]
    string? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc);
