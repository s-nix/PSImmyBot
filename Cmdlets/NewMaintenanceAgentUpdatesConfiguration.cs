using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceAgentUpdatesConfiguration")]
public class NewMaintenanceAgentUpdatesConfiguration : Cmdlet {
    [Parameter(Mandatory = false)] public int? ProviderLinkId { get; set; }

    protected override void ProcessRecord() {
        MaintenanceAgentUpdatesConfiguration outputObject = new(ProviderLinkId);
        WriteObject(outputObject);
    }
}
