using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LatestActionForComputer")]
public class NewGetLatestActionForComputer : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceActionType ActionType { get; set; }
    [Parameter(Mandatory = false)] public int? AssignmentId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType AssignmentType { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = false)] public string? DesiredVersion { get; set; }
    [Parameter(Mandatory = false)] public string? DetectedVersion { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? EndTime { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? PolicyDescription { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionReason Reason { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResult Result { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResultReason ResultReason { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareActionIdForConfigurationTask { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? StartTime { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionStatus Status { get; set; }

    protected override void ProcessRecord() {
        LatestActionForComputer outputObject = new(ActionType, AssignmentId, AssignmentType, CreatedDate, DesiredSoftwareState, DesiredVersion, DetectedVersion, EndTime, Id, MaintenanceDisplayName, MaintenanceIdentifier, MaintenanceSessionId, MaintenanceTaskMode, MaintenanceType, PolicyDescription, Reason, Result, ResultReason, SoftwareActionIdForConfigurationTask, StartTime, Status);
        WriteObject(outputObject);
    }
}
