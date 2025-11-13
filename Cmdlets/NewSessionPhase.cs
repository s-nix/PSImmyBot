using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SessionPhase")]
public class NewSessionPhase : Cmdlet {
    [Parameter(Mandatory = true)] public required ActionProgressPhaseName ActionProgressPhaseName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DateCompletedUtc { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DateStartedUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SessionLog>? Logs { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceAction MaintenanceAction { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceActionId { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSession MaintenanceSession { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSessionStage MaintenanceSessionStage { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionStageId { get; set; }
    [Parameter(Mandatory = false)] public string? PhaseName { get; set; }
    [Parameter(Mandatory = true)] public required bool ProgressCompleted { get; set; }
    [Parameter(Mandatory = false)] public double? ProgressPercentComplete { get; set; }
    [Parameter(Mandatory = false)] public string? ProgressStatus { get; set; }
    [Parameter(Mandatory = true)] public required SessionPhaseStatus Status { get; set; }

    protected override void ProcessRecord() {
        SessionPhase outputObject = new(ActionProgressPhaseName, DateCompletedUtc, DateStartedUtc, Id, Logs, MaintenanceAction, MaintenanceActionId, MaintenanceSession, MaintenanceSessionId, MaintenanceSessionStage, MaintenanceSessionStageId, PhaseName, ProgressCompleted, ProgressPercentComplete, ProgressStatus, Status);
        WriteObject(outputObject);
    }
}
