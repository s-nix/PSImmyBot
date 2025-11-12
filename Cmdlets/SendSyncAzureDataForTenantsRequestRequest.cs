using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SyncAzureDataForTenantsRequestRequest")]
public class SendSyncAzureDataForTenantsRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required SyncAzureDataForTenantsRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/azure/sync-details-from-azure-tenants?";

        List<AzureTenantDetailsSyncResult> response = ImmyBotApiService.Post<SyncAzureDataForTenantsRequest, List<AzureTenantDetailsSyncResult>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
