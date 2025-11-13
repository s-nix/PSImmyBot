using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetMaintenanceSessionStageResponse")]
public class NewGetMaintenanceSessionStageResponse : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? JobId { get; set; }
    [Parameter(Mandatory = true)] public required GetMaintenanceSessionResponse MaintenanceSession { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus StageStatus { get; set; }
    [Parameter(Mandatory = true)] public required SessionStageType Type { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetMaintenanceSessionStageResponse outputObject = new(CreatedBy, CreatedDateUtc, Id, JobId, MaintenanceSession, MaintenanceSessionId, StageStatus, Type, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
