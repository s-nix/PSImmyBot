using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "TargetAssignmentDeploymentChangeRequest")]
public class SendTargetAssignmentDeploymentChangeRequest : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int DeploymentId { get; set; }

    [Parameter(Mandatory = true)]
    public required UpdateLocalTargetAssignmentPayload PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/target-assignments/{DeploymentId}/change-request?";
        ChangeRequestResponse response = ImmyBotApiService
            .Post<UpdateLocalTargetAssignmentPayload, ChangeRequestResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
