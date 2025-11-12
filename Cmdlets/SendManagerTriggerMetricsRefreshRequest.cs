using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ManagerTriggerMetricsRefreshRequest")]
public class SendManagerTriggerMetricsRefreshRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/manager/trigger-metrics-refresh?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
