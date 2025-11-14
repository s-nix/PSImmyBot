using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceSpecifier")]
public class NewMaintenanceSpecifier : Cmdlet {
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceName { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }

    protected override void ProcessRecord() {
        MaintenanceSpecifier outputObject = new(MaintenanceIdentifier, MaintenanceName, MaintenanceType);
        WriteObject(outputObject);
    }
}
