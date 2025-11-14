using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateLocalMaintenanceTaskPayload")]
public class SendUpdateLocalMaintenanceTaskPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateLocalMaintenanceTaskPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/local/{Id}?";

        GetLocalMaintenanceTaskResponse response = ImmyBotApiService.Post<UpdateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
