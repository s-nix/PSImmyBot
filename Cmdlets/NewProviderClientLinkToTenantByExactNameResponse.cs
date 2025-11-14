using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderClientLinkToTenantByExactNameResponse")]
public class NewProviderClientLinkToTenantByExactNameResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? ExternalClientId { get; set; }
    [Parameter(Mandatory = false)] public int? LinkedToTenantId { get; set; }

    protected override void ProcessRecord() {
        ProviderClientLinkToTenantByExactNameResponse outputObject = new(ExternalClientId, LinkedToTenantId);
        WriteObject(outputObject);
    }
}
