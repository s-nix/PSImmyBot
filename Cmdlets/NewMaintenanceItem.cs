using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceItem")]
public class NewMaintenanceItem : Cmdlet {
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkIdForMaintenanceItem { get; set; }

    protected override void ProcessRecord() {
        MaintenanceItem outputObject = new(MaintenanceIdentifier, MaintenanceType, ProviderLinkIdForMaintenanceItem);
        WriteObject(outputObject);
    }
}
