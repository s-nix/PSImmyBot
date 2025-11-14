using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceSessionStage(
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("jobId")] string? JobId,
    [property: JsonPropertyName("logs")] ICollection<SessionLog>? Logs,
    [property: JsonPropertyName("maintenanceSession")]
    MaintenanceSession MaintenanceSession,
    [property: JsonPropertyName("maintenanceSessionId")]
    int MaintenanceSessionId,
    [property: JsonPropertyName("phases")] ICollection<SessionPhase>? Phases,
    [property: JsonPropertyName("stageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus StageStatus,
    [property: JsonPropertyName("type")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStageType>))]
    SessionStageType Type,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
