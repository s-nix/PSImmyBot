using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateTargetAssignmentChangeRequest")]
public class SendCreateTargetAssignmentChangeRequest : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required CreateLocalTargetAssignmentPayload PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/target-assignments/change-request?";
        ChangeRequestResponse response = ImmyBotApiService
            .Post<CreateLocalTargetAssignmentPayload, ChangeRequestResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
