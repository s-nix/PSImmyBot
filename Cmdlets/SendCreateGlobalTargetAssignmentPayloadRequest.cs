using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateGlobalTargetAssignmentPayloadRequest")]
public class SendCreateGlobalTargetAssignmentPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateGlobalTargetAssignmentPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/global/create?";

        GlobalTargetAssignmentResource response = ImmyBotApiService.Post<CreateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
