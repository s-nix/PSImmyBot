using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetMaintenanceActionResponse")]
public class NewGetMaintenanceActionResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceActionType ActionType { get; set; }
    [Parameter(Mandatory = false)] public string? ActionTypeName { get; set; }
    [Parameter(Mandatory = false)] public int? AssignmentId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType AssignmentType { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? DependentsNames { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? DependsOnNames { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = false)] public string? DesiredVersionString { get; set; }
    [Parameter(Mandatory = false)] public string? DetectedVersionString { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset EndTime { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsComputerOnline { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceTaskGetResult { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceTypeName { get; set; }
    [Parameter(Mandatory = false)] public int? ParentId { get; set; }
    [Parameter(Mandatory = false)] public string? PolicyDescription { get; set; }
    [Parameter(Mandatory = false)] public string? PostMaintenanceTest { get; set; }
    [Parameter(Mandatory = false)] public bool? PostMaintenanceTestResult { get; set; }
    [Parameter(Mandatory = false)] public string? PostMaintenanceTestResultMessage { get; set; }
    [Parameter(Mandatory = false)] public int? PostMaintenanceTestType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionReason Reason { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResult Result { get; set; }
    [Parameter(Mandatory = false)] public string? ResultName { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResultReason ResultReason { get; set; }
    [Parameter(Mandatory = false)] public string? ResultReasonMessage { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareActionIdForConfigurationTask { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareProviderType SoftwareProviderType { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset StartTime { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionStatus Status { get; set; }
    [Parameter(Mandatory = false)] public string? StatusName { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetMaintenanceActionResponse outputObject = new(ActionType, ActionTypeName, AssignmentId, AssignmentType, ComputerId, ComputerName, CreatedBy, CreatedDateUtc, DependentsNames, DependsOnNames, Description, DesiredSoftwareState, DesiredVersionString, DetectedVersionString, EndTime, Id, IsComputerOnline, MaintenanceDisplayName, MaintenanceIdentifier, MaintenanceSessionId, MaintenanceTaskGetResult, MaintenanceTaskMode, MaintenanceTaskType, MaintenanceType, MaintenanceTypeName, ParentId, PolicyDescription, PostMaintenanceTest, PostMaintenanceTestResult, PostMaintenanceTestResultMessage, PostMaintenanceTestType, Reason, Result, ResultName, ResultReason, ResultReasonMessage, SoftwareActionIdForConfigurationTask, SoftwareProviderType, SoftwareType, StartTime, Status, StatusName, TenantId, TenantName, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
