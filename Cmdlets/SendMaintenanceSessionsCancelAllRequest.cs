using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MaintenanceSessionsCancelAllRequest")]
public class SendMaintenanceSessionsCancelAllRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/cancel-all?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
