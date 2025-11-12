using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ManagerTriggerConfigRefreshRequest")]
public class SendManagerTriggerConfigRefreshRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/manager/trigger-config-refresh?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
