using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MaintenanceSessionsCancelAll")]
public class SendMaintenanceSessionsCancelAll : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/maintenance-sessions/cancel-all?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
