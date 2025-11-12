using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SyncsAzureUserSyncRequest")]
public class SendSyncsAzureUserSyncRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/syncs/azure-user-sync?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
