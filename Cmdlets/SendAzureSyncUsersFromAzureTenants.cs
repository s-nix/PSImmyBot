using System.Collections.Generic;
using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "AzureSyncUsersFromAzureTenants")]
public class SendAzureSyncUsersFromAzureTenants : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required SyncAzureDataForTenantsRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/azure/sync-users-from-azure-tenants?";
        List<AzureTenantUserSyncResult> response = ImmyBotApiService
            .Post<SyncAzureDataForTenantsRequest, List<AzureTenantUserSyncResult>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
