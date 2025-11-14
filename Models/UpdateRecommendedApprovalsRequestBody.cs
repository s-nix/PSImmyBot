using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateRecommendedApprovalsRequestBody(
    [property: JsonPropertyName("approvals")]
    ICollection<UpdateRecommendedApprovalPayload>? Approvals);
