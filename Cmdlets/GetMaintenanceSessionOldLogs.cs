using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceSessionOldLogs")]
public class GetMaintenanceSessionOldLogs : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}/old-logs?";

        List<GetMaintenanceSessionLogResponse> response = ImmyBotApiService.Get<List<GetMaintenanceSessionLogResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
