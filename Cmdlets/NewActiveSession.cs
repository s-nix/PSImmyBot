using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ActiveSession")]
public class NewActiveSession : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceSession MaintenanceSession { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = true)] public required SessionStatus SessionStatus { get; set; }

    protected override void ProcessRecord() {
        ActiveSession outputObject = new(MaintenanceSession, MaintenanceSessionId, SessionStatus);
        WriteObject(outputObject);
    }
}
