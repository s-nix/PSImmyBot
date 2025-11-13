using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ResolveVisibilityTargetAssignmentsRequestRequest")]
public class SendResolveVisibilityTargetAssignmentsRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ResolveVisibilityTargetAssignmentsRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/visibility?";

        List<TargetAssignmentResource> response = ImmyBotApiService.Post<ResolveVisibilityTargetAssignmentsRequest, List<TargetAssignmentResource>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
