using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MaintenanceSessionsActionsRerunRequest")]
public class SendMaintenanceSessionsActionsRerunRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }

     [Parameter(Mandatory = true)]
    public int ActionId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}/actions/{ActionId}/rerun?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
