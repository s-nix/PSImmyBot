using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateRecommendedApprovalsRequestBodyRequest")]
public class SendUpdateRecommendedApprovalsRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required UpdateRecommendedApprovalsRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/recommended-approvals/update?";

        List<GetRecommendedApprovalResponse> response = ImmyBotApiService.Post<UpdateRecommendedApprovalsRequestBody, List<GetRecommendedApprovalResponse>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
