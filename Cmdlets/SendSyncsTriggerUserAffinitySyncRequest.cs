using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SyncsTriggerUserAffinitySyncRequest")]
public class SendSyncsTriggerUserAffinitySyncRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/syncs/trigger-user-affinity-sync?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
