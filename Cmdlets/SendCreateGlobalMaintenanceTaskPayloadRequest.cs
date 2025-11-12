using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateGlobalMaintenanceTaskPayloadRequest")]
public class SendCreateGlobalMaintenanceTaskPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateGlobalMaintenanceTaskPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/global?";

        GetGlobalMaintenanceTaskResponse response = ImmyBotApiService.Post<CreateGlobalMaintenanceTaskPayload, GetGlobalMaintenanceTaskResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
