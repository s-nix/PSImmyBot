using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateMaintenanceItemOrderPayloadRequest")]
public class SendUpdateMaintenanceItemOrderPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required UpdateMaintenanceItemOrderPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/update-maintenance-item-order?";

        MaintenanceItemOrder response = ImmyBotApiService.Post<UpdateMaintenanceItemOrderPayload, MaintenanceItemOrder>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
