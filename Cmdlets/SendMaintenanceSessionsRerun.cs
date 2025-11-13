using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MaintenanceSessionsRerun")]
public class SendMaintenanceSessionsRerun : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}/rerun?";

        int response = ImmyBotApiService.Post<int>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
