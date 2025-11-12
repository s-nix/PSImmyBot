using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AzureTenantCustomersResult")]
public class GetAzureTenantCustomersResult : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string PartnerPrincipalId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/azure/partner-tenant-customers/{PartnerPrincipalId}?";

        List<AzureTenantCustomersResult> response = ImmyBotApiService.Get<List<AzureTenantCustomersResult>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
