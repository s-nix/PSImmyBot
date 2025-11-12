using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLocalMaintenanceTaskPayloadRequest")]
public class SendCreateLocalMaintenanceTaskPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateLocalMaintenanceTaskPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/local?";

        GetLocalMaintenanceTaskResponse response = ImmyBotApiService.Post<CreateLocalMaintenanceTaskPayload, GetLocalMaintenanceTaskResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
