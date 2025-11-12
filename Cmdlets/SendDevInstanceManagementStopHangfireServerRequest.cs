using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DevInstanceManagementStopHangfireServerRequest")]
public class SendDevInstanceManagementStopHangfireServerRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dev-instance-management/stop-hangfire-server?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
