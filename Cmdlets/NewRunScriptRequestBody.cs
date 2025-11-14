using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunScriptRequestBody")]
public class NewRunScriptRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required Guid CancellationId { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceActionId { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }
    [Parameter(Mandatory = true)] public required Script Script { get; set; }
    [Parameter(Mandatory = false)] public int? SessionLogId { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public Guid? TerminalId { get; set; }

    protected override void ProcessRecord() {
        RunScriptRequestBody outputObject = new(CancellationId, ComputerId, MaintenanceActionId, MaintenanceSessionId, MaintenanceTaskId, MaintenanceTaskType, Script, SessionLogId, TenantId, TerminalId);
        WriteObject(outputObject);
    }
}
