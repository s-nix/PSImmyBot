using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MaintenanceSessionsResumeRequest")]
public class SendMaintenanceSessionsResumeRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}/resume?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
