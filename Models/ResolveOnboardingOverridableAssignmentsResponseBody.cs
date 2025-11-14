using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ResolveOnboardingOverridableAssignmentsResponseBody(
    [property: JsonPropertyName("nextHighestPriorityNonOnboardingOnlyAssignments")]
    ICollection<TargetAssignmentResource>? NextHighestPriorityNonOnboardingOnlyAssignments,
    [property: JsonPropertyName("overridableAssignments")]
    ICollection<TargetAssignmentResource>? OverridableAssignments);
