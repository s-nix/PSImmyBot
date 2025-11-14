using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateMaintenanceItemOrderPayload")]
public class NewUpdateMaintenanceItemOrderPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceItemOrderLocation Location { get; set; }
    [Parameter(Mandatory = false)] public int? ToIndex { get; set; }

    protected override void ProcessRecord() {
        UpdateMaintenanceItemOrderPayload outputObject = new(Id, Location, ToIndex);
        WriteObject(outputObject);
    }
}
