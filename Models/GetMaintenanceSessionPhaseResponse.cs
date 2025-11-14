using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetMaintenanceSessionPhaseResponse(
    [property: JsonPropertyName("actionProgressPhaseName")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ActionProgressPhaseName>))]
    ActionProgressPhaseName ActionProgressPhaseName,
    [property: JsonPropertyName("dateCompletedUtc")]
    DateTimeOffset? DateCompletedUtc,
    [property: JsonPropertyName("dateStartedUtc")]
    DateTimeOffset? DateStartedUtc,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("maintenanceActionId")]
    int? MaintenanceActionId,
    [property: JsonPropertyName("maintenanceSessionId")]
    int MaintenanceSessionId,
    [property: JsonPropertyName("maintenanceSessionStageId")]
    int MaintenanceSessionStageId,
    [property: JsonPropertyName("phaseName")]
    string? PhaseName,
    [property: JsonPropertyName("progressCompleted")]
    bool ProgressCompleted,
    [property: JsonPropertyName("progressPercentComplete")]
    double? ProgressPercentComplete,
    [property: JsonPropertyName("progressStatus")]
    string? ProgressStatus,
    [property: JsonPropertyName("status")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionPhaseStatus>))]
    SessionPhaseStatus Status);
