using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DevInstanceManagementStartHangfireServer")]
public class SendDevInstanceManagementStartHangfireServer : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/dev-instance-management/start-hangfire-server?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
