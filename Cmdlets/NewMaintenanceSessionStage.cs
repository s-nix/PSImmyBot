using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceSessionStage")]
public class NewMaintenanceSessionStage : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? JobId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SessionLog>? Logs { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSession MaintenanceSession { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SessionPhase>? Phases { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus StageStatus { get; set; }
    [Parameter(Mandatory = true)] public required SessionStageType Type { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        MaintenanceSessionStage outputObject = new(CreatedBy, CreatedDate, Id, JobId, Logs, MaintenanceSession, MaintenanceSessionId, Phases, StageStatus, Type, UpdatedBy, UpdatedDate);
        WriteObject(outputObject);
    }
}
