using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceAction(
    [property: JsonPropertyName("actionReason")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionReason>))]
    MaintenanceActionReason ActionReason,

    [property: JsonPropertyName("actionResult")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionResult>))]
    MaintenanceActionResult ActionResult,

    [property: JsonPropertyName("actionResultReason")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionResultReason>))]
    MaintenanceActionResultReason ActionResultReason,

    [property: JsonPropertyName("actionResultReasonMessage")]
    string? ActionResultReasonMessage,

    [property: JsonPropertyName("actionStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionStatus>))]
    MaintenanceActionStatus ActionStatus,

    [property: JsonPropertyName("actionType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionType>))]
    MaintenanceActionType ActionType,

    [property: JsonPropertyName("activities")]
    ICollection<MaintenanceActionActivity>? Activities,

    [property: JsonPropertyName("assignmentId")]
    int? AssignmentId,

    [property: JsonPropertyName("assignmentType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType AssignmentType,

    [property: JsonPropertyName("computerId")]
    int? ComputerId,

    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,

    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,

    [property: JsonPropertyName("dependents")]
    ICollection<MaintenanceActionDependency>? Dependents,

    [property: JsonPropertyName("dependsOn")]
    ICollection<MaintenanceActionDependency>? DependsOn,

    [property: JsonPropertyName("dependsOnActions")]
    ICollection<MaintenanceAction>? DependsOnActions,

    [property: JsonPropertyName("description")]
    string? Description,

    [property: JsonPropertyName("desiredSoftwareState")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DesiredSoftwareState>))]
    DesiredSoftwareState DesiredSoftwareState,

    [property: JsonPropertyName("desiredVersion")]
    SemanticVersion DesiredVersion,

    [property: JsonPropertyName("desiredVersionString")]
    string? DesiredVersionString,

    [property: JsonPropertyName("detectedVersion")]
    SemanticVersion DetectedVersion,

    [property: JsonPropertyName("detectedVersionString")]
    string? DetectedVersionString,

    [property: JsonPropertyName("endTime")]
    DateTimeOffset EndTime,

    [property: JsonPropertyName("hasDeterminedDesiredVersion")]
    bool HasDeterminedDesiredVersion,

    [property: JsonPropertyName("hasDeterminedDetectedVersion")]
    bool HasDeterminedDetectedVersion,

    [property: JsonPropertyName("hasDeterminedTaskGetResult")]
    bool HasDeterminedTaskGetResult,

    [property: JsonPropertyName("hasDeterminedTaskTestResult")]
    bool HasDeterminedTaskTestResult,

    [property: JsonPropertyName("id")]
    int Id,

    [property: JsonPropertyName("isComplete")]
    bool IsComplete,

    [property: JsonPropertyName("isStarted")]
    bool IsStarted,

    [property: JsonPropertyName("lastAction")]
    [property: Obsolete]
    string? LastAction,

    [property: JsonPropertyName("lastActionResult")]
    [property: Obsolete]
    string? LastActionResult,

    [property: JsonPropertyName("lastActionRmmComputerId")]
    [property: Obsolete]
    string? LastActionRmmComputerId,

    [property: JsonPropertyName("lastActionType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptLanguage>))]
    ScriptLanguage LastActionType,

    [property: JsonPropertyName("logs")]
    ICollection<SessionLog>? Logs,

    [property: JsonPropertyName("maintenanceDisplayName")]
    string? MaintenanceDisplayName,

    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,

    [property: JsonPropertyName("maintenanceSession")]
    MaintenanceSession MaintenanceSession,

    [property: JsonPropertyName("maintenanceSessionId")]
    int MaintenanceSessionId,

    [property: JsonPropertyName("maintenanceTaskGetResult")]
    string? MaintenanceTaskGetResult,

    [property: JsonPropertyName("maintenanceTaskMode")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskMode>))]
    MaintenanceTaskMode MaintenanceTaskMode,

    [property: JsonPropertyName("maintenanceTaskType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType MaintenanceTaskType,

    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,

    [property: JsonPropertyName("parameters")]
    string? Parameters,

    [property: JsonPropertyName("parentId")]
    int? ParentId,

    [property: JsonPropertyName("personId")]
    int? PersonId,

    [property: JsonPropertyName("phases")]
    ICollection<SessionPhase>? Phases,

    [property: JsonPropertyName("policyDescription")]
    string? PolicyDescription,

    [property: JsonPropertyName("postMaintenanceTest")]
    string? PostMaintenanceTest,

    [property: JsonPropertyName("postMaintenanceTestResult")]
    bool? PostMaintenanceTestResult,

    [property: JsonPropertyName("postMaintenanceTestResultMessage")]
    string? PostMaintenanceTestResultMessage,

    [property: JsonPropertyName("postMaintenanceTestType")]
    int? PostMaintenanceTestType,

    [property: JsonPropertyName("scriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType ScriptType,

    [property: JsonPropertyName("softwareActionIdForConfigurationTask")]
    int? SoftwareActionIdForConfigurationTask,

    [property: JsonPropertyName("softwareActionIdForConfigurationTaskOrId")]
    int SoftwareActionIdForConfigurationTaskOrId,

    [property: JsonPropertyName("softwareProviderType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareProviderType>))]
    SoftwareProviderType SoftwareProviderType,

    [property: JsonPropertyName("softwareTableRegexString")]
    string? SoftwareTableRegexString,

    [property: JsonPropertyName("softwareType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    SoftwareType SoftwareType,

    [property: JsonPropertyName("startTime")]
    DateTimeOffset StartTime,

    [property: JsonPropertyName("taskTestResult")]
    bool? TaskTestResult,

    [property: JsonPropertyName("tenantId")]
    int? TenantId,

    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,

    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,

    [property: JsonPropertyName("usesManualProgressControl")]
    bool UsesManualProgressControl
);
