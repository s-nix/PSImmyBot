using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SyncAgentsForClientsRequest")]
public class NewSyncAgentsForClientsRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? ClientIds { get; set; }

    protected override void ProcessRecord() {
        SyncAgentsForClientsRequest outputObject = new(ClientIds);
        WriteObject(outputObject);
    }
}
