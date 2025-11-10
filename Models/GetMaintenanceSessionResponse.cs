using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetMaintenanceSessionResponse(
    [property: JsonPropertyName("activities")]
    ICollection<MaintenanceActionActivityResponse>? Activities,
    [property: JsonPropertyName("agentUpdatesStageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus AgentUpdatesStageStatus,
    [property: JsonPropertyName("computer")]
    GetComputerResponse Computer,
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("createdBy")]
    string? CreatedBy,
    [property: JsonPropertyName("createdById")]
    int? CreatedById,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("detectionStageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus DetectionStageStatus,
    [property: JsonPropertyName("duration")]
    string? Duration,
    [property: JsonPropertyName("executionStageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus ExecutionStageStatus,
    [property: JsonPropertyName("fullMaintenance")]
    bool FullMaintenance,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("inventoryStageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus InventoryStageStatus,
    [property: JsonPropertyName("jobId")] string? JobId,
    [property: JsonPropertyName("logs")] ICollection<GetSessionLogResponse>? Logs,
    [property: JsonPropertyName("maintenanceActions")]
    ICollection<GetMaintenanceActionResponse>? MaintenanceActions,
    [property: JsonPropertyName("onboarding")]
    bool Onboarding,
    [property: JsonPropertyName("onboardingStageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus OnboardingStageStatus,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("resolutionStageStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus ResolutionStageStatus,
    [property: JsonPropertyName("scheduledExecutionDate")]
    DateTimeOffset? ScheduledExecutionDate,
    [property: JsonPropertyName("scheduledId")]
    int? ScheduledId,
    [property: JsonPropertyName("sessionJobArgs")]
    SessionJobArgs SessionJobArgs,
    [property: JsonPropertyName("sessionStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus SessionStatus,
    [property: JsonPropertyName("stages")] ICollection<GetMaintenanceSessionStageResponse>? Stages,
    [property: JsonPropertyName("tenant")] GetTenantResponse Tenant,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("updatedById")]
    int? UpdatedById,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc);
