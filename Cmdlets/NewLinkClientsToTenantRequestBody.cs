using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LinkClientsToTenantRequestBody")]
public class NewLinkClientsToTenantRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? ClientIds { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        LinkClientsToTenantRequestBody outputObject = new(ClientIds, TenantId);
        WriteObject(outputObject);
    }
}
