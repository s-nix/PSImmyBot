using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLocalTargetAssignmentPayload")]
public class SendCreateLocalTargetAssignmentPayload : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateLocalTargetAssignmentPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments?";

        LocalTargetAssignmentResource response = ImmyBotApiService.Post<CreateLocalTargetAssignmentPayload, LocalTargetAssignmentResource>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
