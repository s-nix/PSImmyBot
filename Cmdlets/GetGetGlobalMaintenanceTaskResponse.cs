using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetGlobalMaintenanceTaskResponse")]
public class GetGetGlobalMaintenanceTaskResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/global/{Id}?";

        GetGlobalMaintenanceTaskResponse response = ImmyBotApiService.Get<GetGlobalMaintenanceTaskResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
