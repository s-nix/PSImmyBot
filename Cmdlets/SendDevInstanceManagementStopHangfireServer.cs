using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DevInstanceManagementStopHangfireServer")]
public class SendDevInstanceManagementStopHangfireServer : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/dev-instance-management/stop-hangfire-server?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
