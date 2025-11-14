using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DuplicateMaintenanceTaskRequestbody")]
public class NewDuplicateMaintenanceTaskRequestbody : Cmdlet {
    [Parameter(Mandatory = true)] public required int MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }

    protected override void ProcessRecord() {
        DuplicateMaintenanceTaskRequestbody outputObject = new(MaintenanceTaskId, MaintenanceTaskType);
        WriteObject(outputObject);
    }
}
