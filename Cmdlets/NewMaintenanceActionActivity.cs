using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceActionActivity")]
public class NewMaintenanceActionActivity : Cmdlet {
    [Parameter(Mandatory = false)] public string? Activity { get; set; }
    [Parameter(Mandatory = false)] public string? ActivityId { get; set; }
    [Parameter(Mandatory = false)] public bool? Completed { get; set; }
    [Parameter(Mandatory = false)] public string? CurrentOperation { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceAction MaintenanceAction { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceActionId { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSession MaintenanceSession { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = false)] public string? ParentId { get; set; }
    [Parameter(Mandatory = false)] public int? PercentComplete { get; set; }
    [Parameter(Mandatory = false)] public string? ScriptName { get; set; }
    [Parameter(Mandatory = false)] public int? SecondsRemaining { get; set; }
    [Parameter(Mandatory = false)] public string? SourceId { get; set; }
    [Parameter(Mandatory = false)] public string? Status { get; set; }

    protected override void ProcessRecord() {
        MaintenanceActionActivity outputObject = new(Activity, ActivityId, Completed, CurrentOperation, DateUtc, Id, MaintenanceAction, MaintenanceActionId, MaintenanceSession, MaintenanceSessionId, ParentId, PercentComplete, ScriptName, SecondsRemaining, SourceId, Status);
        WriteObject(outputObject);
    }
}
