using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceSessionsCancel")]
public class GetMaintenanceSessionsCancel : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}/cancel?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
