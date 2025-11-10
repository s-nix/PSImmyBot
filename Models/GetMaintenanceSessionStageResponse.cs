using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetMaintenanceSessionStageResponse(
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("jobId")] string? JobId,
    [property: JsonPropertyName("maintenanceSession")]
    GetMaintenanceSessionResponse MaintenanceSession,
    [property: JsonPropertyName("maintenanceSessionId")]
    int MaintenanceSessionId,
    [property: JsonPropertyName("stageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus StageStatus,
    [property: JsonPropertyName("type")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStageType>))]
    SessionStageType Type,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc);
