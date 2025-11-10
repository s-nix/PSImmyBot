using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SessionLog(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("immediateUser")]
    bool? ImmediateUser,
    [property: JsonPropertyName("isPrimary")]
    bool IsPrimary,
    [property: JsonPropertyName("maintenanceAction")]
    MaintenanceAction MaintenanceAction,
    [property: JsonPropertyName("maintenanceActionId")]
    int? MaintenanceActionId,
    [property: JsonPropertyName("maintenanceActionStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionStatus>))]
    MaintenanceActionStatus MaintenanceActionStatus,
    [property: JsonPropertyName("maintenanceSession")]
    MaintenanceSession MaintenanceSession,
    [property: JsonPropertyName("maintenanceSessionId")]
    int MaintenanceSessionId,
    [property: JsonPropertyName("maintenanceSessionStage")]
    MaintenanceSessionStage MaintenanceSessionStage,
    [property: JsonPropertyName("maintenanceSessionStageId")]
    int? MaintenanceSessionStageId,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("paramBlockParameters")]
    IDictionary<string, object?>? ParamBlockParameters,
    [property: JsonPropertyName("progressActivity")]
    string? ProgressActivity,
    [property: JsonPropertyName("progressCompleted")]
    bool ProgressCompleted,
    [property: JsonPropertyName("progressCorrelationId")]
    Guid? ProgressCorrelationId,
    [property: JsonPropertyName("progressCurrentOperation")]
    string? ProgressCurrentOperation,
    [property: JsonPropertyName("progressPercentComplete")]
    double? ProgressPercentComplete,
    [property: JsonPropertyName("progressSecondsRemaining")]
    double? ProgressSecondsRemaining,
    [property: JsonPropertyName("progressStatus")]
    string? ProgressStatus,
    [property: JsonPropertyName("script")] string? Script,
    [property: JsonPropertyName("scriptExecutionContext")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptExecutionContext>))]
    ScriptExecutionContext ScriptExecutionContext,
    [property: JsonPropertyName("scriptId")]
    int? ScriptId,
    [property: JsonPropertyName("scriptLanguage")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptLanguage>))]
    ScriptLanguage ScriptLanguage,
    [property: JsonPropertyName("scriptOutput")]
    string? ScriptOutput,
    [property: JsonPropertyName("scriptParameters")]
    IDictionary<string, object?>? ScriptParameters,
    [property: JsonPropertyName("scriptTimeout")]
    int? ScriptTimeout,
    [property: JsonPropertyName("scriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType ScriptType,
    [property: JsonPropertyName("sessionLogType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionLogType>))]
    SessionLogType SessionLogType,
    [property: JsonPropertyName("sessionPhase")]
    SessionPhase SessionPhase,
    [property: JsonPropertyName("sessionPhaseId")]
    int? SessionPhaseId,
    [property: JsonPropertyName("time")] DateTimeOffset Time,
    [property: JsonPropertyName("updatedTime")]
    DateTimeOffset? UpdatedTime);
