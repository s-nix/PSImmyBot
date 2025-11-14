using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateLocalTargetAssignmentPayload")]
public class SendUpdateLocalTargetAssignmentPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ChangeRequestId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateLocalTargetAssignmentPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/change-request/{ChangeRequestId}?";

        ChangeRequestResponse response = ImmyBotApiService.Post<UpdateLocalTargetAssignmentPayload, ChangeRequestResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
