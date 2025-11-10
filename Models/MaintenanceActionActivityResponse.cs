using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceActionActivityResponse(
    [property: JsonPropertyName("activity")]
    string? Activity,
    [property: JsonPropertyName("activityId")]
    string? ActivityId,
    [property: JsonPropertyName("completed")]
    bool? Completed,
    [property: JsonPropertyName("currentOperation")]
    string? CurrentOperation,
    [property: JsonPropertyName("dateUtc")]
    DateTimeOffset DateUtc,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("maintenanceActionId")]
    int MaintenanceActionId,
    [property: JsonPropertyName("maintenanceSessionId")]
    int MaintenanceSessionId,
    [property: JsonPropertyName("parentId")]
    string? ParentId,
    [property: JsonPropertyName("percentComplete")]
    int? PercentComplete,
    [property: JsonPropertyName("scriptName")]
    string? ScriptName,
    [property: JsonPropertyName("secondsRemaining")]
    int? SecondsRemaining,
    [property: JsonPropertyName("sourceId")]
    string? SourceId,
    [property: JsonPropertyName("status")] string? Status);
