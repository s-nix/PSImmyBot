using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateGlobalMaintenanceTaskPayload")]
public class SendUpdateGlobalMaintenanceTaskPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateGlobalMaintenanceTaskPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/global/{Id}?";

        GetGlobalMaintenanceTaskResponse response = ImmyBotApiService.Post<UpdateGlobalMaintenanceTaskPayload, GetGlobalMaintenanceTaskResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
