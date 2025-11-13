using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetMaintenanceSessionPhaseResponse")]
public class NewGetMaintenanceSessionPhaseResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required ActionProgressPhaseName ActionProgressPhaseName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DateCompletedUtc { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DateStartedUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceActionId { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionStageId { get; set; }
    [Parameter(Mandatory = false)] public string? PhaseName { get; set; }
    [Parameter(Mandatory = true)] public required bool ProgressCompleted { get; set; }
    [Parameter(Mandatory = false)] public double? ProgressPercentComplete { get; set; }
    [Parameter(Mandatory = false)] public string? ProgressStatus { get; set; }
    [Parameter(Mandatory = true)] public required SessionPhaseStatus Status { get; set; }

    protected override void ProcessRecord() {
        GetMaintenanceSessionPhaseResponse outputObject = new(ActionProgressPhaseName, DateCompletedUtc, DateStartedUtc, Id, MaintenanceActionId, MaintenanceSessionId, MaintenanceSessionStageId, PhaseName, ProgressCompleted, ProgressPercentComplete, ProgressStatus, Status);
        WriteObject(outputObject);
    }
}
