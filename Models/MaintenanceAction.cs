using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record MaintenanceAction {
    [JsonConstructor]
    [Obsolete]
    public MaintenanceAction(MaintenanceActionReason @actionReason, MaintenanceActionResult @actionResult, MaintenanceActionResultReason @actionResultReason, string? @actionResultReasonMessage, MaintenanceActionStatus @actionStatus, MaintenanceActionType @actionType, ICollection<MaintenanceActionActivity>? @activities, int? @assignmentId, DatabaseType @assignmentType, int? @computerId, int? @createdBy, DateTimeOffset @createdDate, ICollection<MaintenanceActionDependency>? @dependents, ICollection<MaintenanceActionDependency>? @dependsOn, ICollection<MaintenanceAction>? @dependsOnActions, string? @description, DesiredSoftwareState @desiredSoftwareState, SemanticVersion @desiredVersion, string? @desiredVersionString, SemanticVersion @detectedVersion, string? @detectedVersionString, DateTimeOffset @endTime, bool @hasDeterminedDesiredVersion, bool @hasDeterminedDetectedVersion, bool @hasDeterminedTaskGetResult, bool @hasDeterminedTaskTestResult, int @id, bool @isComplete, bool @isStarted, string? @lastAction, string? @lastActionResult, string? @lastActionRmmComputerId, ScriptLanguage @lastActionType, ICollection<SessionLog>? @logs, string? @maintenanceDisplayName, string? @maintenanceIdentifier, MaintenanceSession @maintenanceSession, int @maintenanceSessionId, string? @maintenanceTaskGetResult, MaintenanceTaskMode @maintenanceTaskMode, DatabaseType @maintenanceTaskType, MaintenanceType @maintenanceType, string? @parameters, int? @parentId, int? @personId, ICollection<SessionPhase>? @phases, string? @policyDescription, string? @postMaintenanceTest, bool? @postMaintenanceTestResult, string? @postMaintenanceTestResultMessage, int? @postMaintenanceTestType, DatabaseType @scriptType, int? @softwareActionIdForConfigurationTask, int @softwareActionIdForConfigurationTaskOrId, SoftwareProviderType @softwareProviderType, string? @softwareTableRegexString, SoftwareType @softwareType, DateTimeOffset @startTime, bool? @taskTestResult, int? @tenantId, int? @updatedBy, DateTimeOffset @updatedDate, bool @usesManualProgressControl) {
        CreatedDate = @createdDate;
        UpdatedDate = @updatedDate;
        CreatedBy = @createdBy;
        UpdatedBy = @updatedBy;
        Id = @id;
        ComputerId = @computerId;
        TenantId = @tenantId;
        PersonId = @personId;
        MaintenanceSessionId = @maintenanceSessionId;
        AssignmentId = @assignmentId;
        AssignmentType = @assignmentType;
        MaintenanceType = @maintenanceType;
        MaintenanceIdentifier = @maintenanceIdentifier;
        MaintenanceDisplayName = @maintenanceDisplayName;
        ActionType = @actionType;
        DesiredSoftwareState = @desiredSoftwareState;
        MaintenanceTaskMode = @maintenanceTaskMode;
        DetectedVersion = @detectedVersion;
        DetectedVersionString = @detectedVersionString;
        HasDeterminedDetectedVersion = @hasDeterminedDetectedVersion;
        DesiredVersion = @desiredVersion;
        DesiredVersionString = @desiredVersionString;
        HasDeterminedDesiredVersion = @hasDeterminedDesiredVersion;
        MaintenanceTaskGetResult = @maintenanceTaskGetResult;
        HasDeterminedTaskGetResult = @hasDeterminedTaskGetResult;
        TaskTestResult = @taskTestResult;
        HasDeterminedTaskTestResult = @hasDeterminedTaskTestResult;
        SoftwareActionIdForConfigurationTask = @softwareActionIdForConfigurationTask;
        SoftwareProviderType = @softwareProviderType;
        ActionStatus = @actionStatus;
        ActionReason = @actionReason;
        ActionResult = @actionResult;
        ActionResultReason = @actionResultReason;
        PolicyDescription = @policyDescription;
        ActionResultReasonMessage = @actionResultReasonMessage;
        PostMaintenanceTest = @postMaintenanceTest;
        PostMaintenanceTestType = @postMaintenanceTestType;
        PostMaintenanceTestResult = @postMaintenanceTestResult;
        PostMaintenanceTestResultMessage = @postMaintenanceTestResultMessage;
        SoftwareType = @softwareType;
        MaintenanceTaskType = @maintenanceTaskType;
        ScriptType = @scriptType;
        StartTime = @startTime;
        EndTime = @endTime;
        SoftwareTableRegexString = @softwareTableRegexString;
        Description = @description;
        SoftwareActionIdForConfigurationTaskOrId = @softwareActionIdForConfigurationTaskOrId;
        IsStarted = @isStarted;
        IsComplete = @isComplete;
        MaintenanceSession = @maintenanceSession;
        Logs = @logs;
        Phases = @phases;
        DependsOn = @dependsOn;
        Dependents = @dependents;
        DependsOnActions = @dependsOnActions;
        Activities = @activities;
        LastAction = @lastAction;
        LastActionResult = @lastActionResult;
        LastActionType = @lastActionType;
        LastActionRmmComputerId = @lastActionRmmComputerId;
        Parameters = @parameters;
        ParentId = @parentId;
        UsesManualProgressControl = @usesManualProgressControl;
    }

    [JsonPropertyName("createdDate")]
    public DateTimeOffset CreatedDate { get; init; }

    [JsonPropertyName("updatedDate")]
    public DateTimeOffset UpdatedDate { get; init; }

    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; init; }

    [JsonPropertyName("updatedBy")]
    public int? UpdatedBy { get; init; }

    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("computerId")]
    public int? ComputerId { get; init; }

    [JsonPropertyName("tenantId")]
    public int? TenantId { get; init; }

    [JsonPropertyName("personId")]
    public int? PersonId { get; init; }

    [JsonPropertyName("maintenanceSessionId")]
    public int MaintenanceSessionId { get; init; }

    [JsonPropertyName("assignmentId")]
    public int? AssignmentId { get; init; }

    [JsonPropertyName("assignmentType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType AssignmentType { get; init; }

    [JsonPropertyName("maintenanceType")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    public MaintenanceType MaintenanceType { get; init; }

    [JsonPropertyName("maintenanceIdentifier")]
    public string? MaintenanceIdentifier { get; init; }

    [JsonPropertyName("maintenanceDisplayName")]
    public string? MaintenanceDisplayName { get; init; }

    [JsonPropertyName("actionType")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionType>))]
    public MaintenanceActionType ActionType { get; init; }

    [JsonPropertyName("desiredSoftwareState")]
    [JsonConverter(typeof(JsonStringEnumConverter<DesiredSoftwareState>))]
    public DesiredSoftwareState DesiredSoftwareState { get; init; }

    [JsonPropertyName("maintenanceTaskMode")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskMode>))]
    public MaintenanceTaskMode MaintenanceTaskMode { get; init; }

    [JsonPropertyName("detectedVersion")]
    public SemanticVersion DetectedVersion { get; init; }

    [JsonPropertyName("detectedVersionString")]
    public string? DetectedVersionString { get; init; }

    [JsonPropertyName("hasDeterminedDetectedVersion")]
    public bool HasDeterminedDetectedVersion { get; init; }

    [JsonPropertyName("desiredVersion")]
    public SemanticVersion DesiredVersion { get; init; }

    [JsonPropertyName("desiredVersionString")]
    public string? DesiredVersionString { get; init; }

    [JsonPropertyName("hasDeterminedDesiredVersion")]
    public bool HasDeterminedDesiredVersion { get; init; }

    [JsonPropertyName("maintenanceTaskGetResult")]
    public string? MaintenanceTaskGetResult { get; init; }

    [JsonPropertyName("hasDeterminedTaskGetResult")]
    public bool HasDeterminedTaskGetResult { get; init; }

    [JsonPropertyName("taskTestResult")]
    public bool? TaskTestResult { get; init; }

    [JsonPropertyName("hasDeterminedTaskTestResult")]
    public bool HasDeterminedTaskTestResult { get; init; }

    [JsonPropertyName("softwareActionIdForConfigurationTask")]
    public int? SoftwareActionIdForConfigurationTask { get; init; }

    [JsonPropertyName("softwareProviderType")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareProviderType>))]
    public SoftwareProviderType SoftwareProviderType { get; init; }

    [JsonPropertyName("actionStatus")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionStatus>))]
    public MaintenanceActionStatus ActionStatus { get; init; }

    [JsonPropertyName("actionReason")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionReason>))]
    public MaintenanceActionReason ActionReason { get; init; }

    [JsonPropertyName("actionResult")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionResult>))]
    public MaintenanceActionResult ActionResult { get; init; }

    [JsonPropertyName("actionResultReason")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionResultReason>))]
    public MaintenanceActionResultReason ActionResultReason { get; init; }

    [JsonPropertyName("policyDescription")]
    public string? PolicyDescription { get; init; }

    [JsonPropertyName("actionResultReasonMessage")]
    public string? ActionResultReasonMessage { get; init; }

    [JsonPropertyName("postMaintenanceTest")]
    public string? PostMaintenanceTest { get; init; }

    [JsonPropertyName("postMaintenanceTestType")]
    public int? PostMaintenanceTestType { get; init; }

    [JsonPropertyName("postMaintenanceTestResult")]
    public bool? PostMaintenanceTestResult { get; init; }

    [JsonPropertyName("postMaintenanceTestResultMessage")]
    public string? PostMaintenanceTestResultMessage { get; init; }

    [JsonPropertyName("softwareType")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    public SoftwareType SoftwareType { get; init; }

    [JsonPropertyName("maintenanceTaskType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType MaintenanceTaskType { get; init; }

    [JsonPropertyName("scriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType ScriptType { get; init; }

    [JsonPropertyName("startTime")]
    public DateTimeOffset StartTime { get; init; }

    [JsonPropertyName("endTime")]
    public DateTimeOffset EndTime { get; init; }

    [JsonPropertyName("softwareTableRegexString")]
    public string? SoftwareTableRegexString { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("softwareActionIdForConfigurationTaskOrId")]
    public int SoftwareActionIdForConfigurationTaskOrId { get; init; }

    [JsonPropertyName("isStarted")]
    public bool IsStarted { get; init; }

    [JsonPropertyName("isComplete")]
    public bool IsComplete { get; init; }

    [JsonPropertyName("maintenanceSession")]
    public MaintenanceSession MaintenanceSession { get; init; }

    [JsonPropertyName("logs")]
    public ICollection<SessionLog>? Logs { get; init; }

    [JsonPropertyName("phases")]
    public ICollection<SessionPhase>? Phases { get; init; }

    [JsonPropertyName("dependsOn")]
    public ICollection<MaintenanceActionDependency>? DependsOn { get; init; }

    [JsonPropertyName("dependents")]
    public ICollection<MaintenanceActionDependency>? Dependents { get; init; }

    [JsonPropertyName("dependsOnActions")]
    public ICollection<MaintenanceAction>? DependsOnActions { get; init; }

    [JsonPropertyName("activities")]
    public ICollection<MaintenanceActionActivity>? Activities { get; init; }

    [JsonPropertyName("lastAction")]
    [Obsolete]
    public string? LastAction { get; init; }

    [JsonPropertyName("lastActionResult")]
    [Obsolete]
    public string? LastActionResult { get; init; }

    [JsonPropertyName("lastActionType")]
    [JsonConverter(typeof(JsonStringEnumConverter<ScriptLanguage>))]
    public ScriptLanguage LastActionType { get; init; }

    [JsonPropertyName("lastActionRmmComputerId")]
    [Obsolete]
    public string? LastActionRmmComputerId { get; init; }

    [JsonPropertyName("parameters")]
    public string? Parameters { get; init; }

    [JsonPropertyName("parentId")]
    public int? ParentId { get; init; }

    [JsonPropertyName("usesManualProgressControl")]
    public bool UsesManualProgressControl { get; init; }
}
