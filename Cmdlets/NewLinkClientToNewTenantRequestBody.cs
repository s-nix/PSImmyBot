using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LinkClientToNewTenantRequestBody")]
public class NewLinkClientToNewTenantRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? ExternalClientId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }

    protected override void ProcessRecord() {
        LinkClientToNewTenantRequestBody outputObject = new(ExternalClientId, TenantName);
        WriteObject(outputObject);
    }
}
