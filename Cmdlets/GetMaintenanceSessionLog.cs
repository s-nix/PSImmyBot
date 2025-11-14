using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceSessionLog")]
public class GetMaintenanceSessionLog : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}/last-log?";

        GetMaintenanceSessionLogResponse response = ImmyBotApiService.Get<GetMaintenanceSessionLogResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
