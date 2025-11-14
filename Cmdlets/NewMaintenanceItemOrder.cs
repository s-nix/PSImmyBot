using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceItemOrder")]
public class NewMaintenanceItemOrder : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceItemOrderLocation Location { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = true)] public required double SortOrder { get; set; }

    protected override void ProcessRecord() {
        MaintenanceItemOrder outputObject = new(Id, Location, MaintenanceIdentifier, MaintenanceType, SortOrder);
        WriteObject(outputObject);
    }
}
