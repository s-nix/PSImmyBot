using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SoftwareSpecifier")]
public class NewSoftwareSpecifier : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceSpecifier MaintenanceSpecifier { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }

    protected override void ProcessRecord() {
        SoftwareSpecifier outputObject = new(MaintenanceSpecifier, SoftwareIdentifier, SoftwareType);
        WriteObject(outputObject);
    }
}
