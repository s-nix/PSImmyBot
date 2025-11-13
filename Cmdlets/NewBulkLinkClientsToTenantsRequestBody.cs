using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkLinkClientsToTenantsRequestBody")]
public class NewBulkLinkClientsToTenantsRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? ClientIds { get; set; }

    protected override void ProcessRecord() {
        BulkLinkClientsToTenantsRequestBody outputObject = new(ClientIds);
        WriteObject(outputObject);
    }
}
