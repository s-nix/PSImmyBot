using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetMaintenanceSessionPhaseResponse")]
public class GetGetMaintenanceSessionPhaseResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}/phases?";

        List<GetMaintenanceSessionPhaseResponse> response = ImmyBotApiService.Get<List<GetMaintenanceSessionPhaseResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
