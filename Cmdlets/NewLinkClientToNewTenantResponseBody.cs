using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LinkClientToNewTenantResponseBody")]
public class NewLinkClientToNewTenantResponseBody : Cmdlet {
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }

    protected override void ProcessRecord() {
        LinkClientToNewTenantResponseBody outputObject = new(TenantId, TenantName);
        WriteObject(outputObject);
    }
}
