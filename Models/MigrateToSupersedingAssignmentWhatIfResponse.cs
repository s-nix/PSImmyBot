using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MigrateToSupersedingAssignmentWhatIfResponse(
    [property: JsonPropertyName("assignment")]
    LocalTargetAssignmentResource Assignment, [property: JsonPropertyName("isNew")] bool IsNew,
    [property: JsonPropertyName("policyDescription")]
    string? PolicyDescription);
