using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantLinkDomainFilter")]
public class NewAzureTenantLinkDomainFilter : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzTenantId { get; set; }
    [Parameter(Mandatory = false)] public string? DomainName { get; set; }
    [Parameter(Mandatory = true)] public required int ImmyTenantId { get; set; }

    protected override void ProcessRecord() {
        AzureTenantLinkDomainFilter outputObject = new(AzTenantId, DomainName, ImmyTenantId);
        WriteObject(outputObject);
    }
}
