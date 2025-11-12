using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DuplicateTargetAssignmentPayloadRequest")]
public class SendDuplicateTargetAssignmentPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required DuplicateTargetAssignmentPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/duplicates?";

        TargetAssignmentDuplicateResponse response = ImmyBotApiService.Post<DuplicateTargetAssignmentPayload, TargetAssignmentDuplicateResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
