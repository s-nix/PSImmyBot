using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RecommendedTargetAssignmentApproval(
    [property: JsonPropertyName("approved")]
    bool Approved,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("globalTargetAssignmentId")]
    int GlobalTargetAssignmentId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
