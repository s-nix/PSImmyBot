using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceActionLogs")]
public class GetMaintenanceActionLogs : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ActionId { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/maintenance-actions/{ActionId}/logs?";

        List<GetMaintenanceSessionLogResponse> response = ImmyBotApiService.Get<List<GetMaintenanceSessionLogResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
