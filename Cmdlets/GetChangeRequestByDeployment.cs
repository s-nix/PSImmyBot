using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ChangeRequestByDeployment")]
public class GetChangeRequestByDeployment : Cmdlet {
    [Parameter(Mandatory = true)]
    public int DeploymentId { get; set; }

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/{DeploymentId}/change-requests?";

        List<ChangeRequestResponse> response = ImmyBotApiService.Get<List<ChangeRequestResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
