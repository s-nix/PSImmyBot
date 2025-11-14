using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceAction")]
public class NewMaintenanceAction : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceActionReason ActionReason { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResult ActionResult { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResultReason ActionResultReason { get; set; }
    [Parameter(Mandatory = false)] public string? ActionResultReasonMessage { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionStatus ActionStatus { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionType ActionType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceActionActivity>? Activities { get; set; }
    [Parameter(Mandatory = false)] public int? AssignmentId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType AssignmentType { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceActionDependency>? Dependents { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceActionDependency>? DependsOn { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceAction>? DependsOnActions { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion DesiredVersion { get; set; }
    [Parameter(Mandatory = false)] public string? DesiredVersionString { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion DetectedVersion { get; set; }
    [Parameter(Mandatory = false)] public string? DetectedVersionString { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset EndTime { get; set; }
    [Parameter(Mandatory = true)] public required bool HasDeterminedDesiredVersion { get; set; }
    [Parameter(Mandatory = true)] public required bool HasDeterminedDetectedVersion { get; set; }
    [Parameter(Mandatory = true)] public required bool HasDeterminedTaskGetResult { get; set; }
    [Parameter(Mandatory = true)] public required bool HasDeterminedTaskTestResult { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsComplete { get; set; }
    [Parameter(Mandatory = true)] public required bool IsStarted { get; set; }
    [Parameter(Mandatory = false)] public string? LastAction { get; set; }
    [Parameter(Mandatory = false)] public string? LastActionResult { get; set; }
    [Parameter(Mandatory = false)] public string? LastActionRmmComputerId { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage LastActionType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SessionLog>? Logs { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSession MaintenanceSession { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceTaskGetResult { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Parameters { get; set; }
    [Parameter(Mandatory = false)] public int? ParentId { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SessionPhase>? Phases { get; set; }
    [Parameter(Mandatory = false)] public string? PolicyDescription { get; set; }
    [Parameter(Mandatory = false)] public string? PostMaintenanceTest { get; set; }
    [Parameter(Mandatory = false)] public bool? PostMaintenanceTestResult { get; set; }
    [Parameter(Mandatory = false)] public string? PostMaintenanceTestResultMessage { get; set; }
    [Parameter(Mandatory = false)] public int? PostMaintenanceTestType { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareActionIdForConfigurationTask { get; set; }
    [Parameter(Mandatory = true)] public required int SoftwareActionIdForConfigurationTaskOrId { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareProviderType SoftwareProviderType { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareTableRegexString { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset StartTime { get; set; }
    [Parameter(Mandatory = false)] public bool? TaskTestResult { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required bool UsesManualProgressControl { get; set; }

    protected override void ProcessRecord() {
        MaintenanceAction outputObject = new(ActionReason, ActionResult, ActionResultReason, ActionResultReasonMessage, ActionStatus, ActionType, Activities, AssignmentId, AssignmentType, ComputerId, CreatedBy, CreatedDate, Dependents, DependsOn, DependsOnActions, Description, DesiredSoftwareState, DesiredVersion, DesiredVersionString, DetectedVersion, DetectedVersionString, EndTime, HasDeterminedDesiredVersion, HasDeterminedDetectedVersion, HasDeterminedTaskGetResult, HasDeterminedTaskTestResult, Id, IsComplete, IsStarted, LastAction, LastActionResult, LastActionRmmComputerId, LastActionType, Logs, MaintenanceDisplayName, MaintenanceIdentifier, MaintenanceSession, MaintenanceSessionId, MaintenanceTaskGetResult, MaintenanceTaskMode, MaintenanceTaskType, MaintenanceType, Parameters, ParentId, PersonId, Phases, PolicyDescription, PostMaintenanceTest, PostMaintenanceTestResult, PostMaintenanceTestResultMessage, PostMaintenanceTestType, ScriptType, SoftwareActionIdForConfigurationTask, SoftwareActionIdForConfigurationTaskOrId, SoftwareProviderType, SoftwareTableRegexString, SoftwareType, StartTime, TaskTestResult, TenantId, UpdatedBy, UpdatedDate, UsesManualProgressControl);
        WriteObject(outputObject);
    }
}
