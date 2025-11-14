using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceSession(
    [property: JsonPropertyName("activeSession")]
    ActiveSession ActiveSession,
    [property: JsonPropertyName("activities")]
    ICollection<MaintenanceActionActivity>? Activities,
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("duration")]
    string? Duration,
    [property: JsonPropertyName("fullMaintenance")]
    bool FullMaintenance,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("jobArgs")]
    SessionJobArgs JobArgs,
    [property: JsonPropertyName("jobId")] string? JobId,
    [property: JsonPropertyName("logs")] ICollection<SessionLog>? Logs,
    [property: JsonPropertyName("maintenanceActions")]
    ICollection<MaintenanceAction>? MaintenanceActions,
    [property: JsonPropertyName("onboarding")]
    bool Onboarding,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("person")] Person Person,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("phases")] ICollection<SessionPhase>? Phases,
    [property: JsonPropertyName("scheduledExecutionDate")]
    DateTimeOffset? ScheduledExecutionDate,
    [property: JsonPropertyName("scheduledId")]
    int? ScheduledId,
    [property: JsonPropertyName("sessionStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus SessionStatus,
    [property: JsonPropertyName("stages")] ICollection<MaintenanceSessionStage>? Stages,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,
    [property: JsonPropertyName("usingActiveHours")]
    bool UsingActiveHours);
