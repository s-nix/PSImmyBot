using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantCustomersResult")]
public class NewAzureTenantCustomersResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantCustomerICollectionAzureErrorOneOf Result { get; set; }

    protected override void ProcessRecord() {
        AzureTenantCustomersResult outputObject = new(PartnerPrincipalId, Result);
        WriteObject(outputObject);
    }
}
