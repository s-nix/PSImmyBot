using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceAction")]
public class GetMaintenanceAction : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-actions/computer/{ComputerId}/needs-attention?";

        List<GetMaintenanceActionResponse> response = ImmyBotApiService.Get<List<GetMaintenanceActionResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
