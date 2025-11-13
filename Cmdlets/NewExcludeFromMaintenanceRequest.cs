using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ExcludeFromMaintenanceRequest")]
public class NewExcludeFromMaintenanceRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Exclude { get; set; }

    protected override void ProcessRecord() {
        ExcludeFromMaintenanceRequest outputObject = new(Exclude);
        WriteObject(outputObject);
    }
}
