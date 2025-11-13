using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "OptionalTargetAssignmentApproval")]
public class GetOptionalTargetAssignmentApproval : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/optional-target-assignment-approvals/computer/{ComputerId}?";

        List<GetOptionalTargetAssignmentApprovalResponse> response = ImmyBotApiService.Get<List<GetOptionalTargetAssignmentApprovalResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
