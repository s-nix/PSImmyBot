using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "RecommendedApproval")]
public class GetRecommendedApproval : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/recommended-approvals?";

        List<GetRecommendedApprovalResponse> response = ImmyBotApiService.Get<List<GetRecommendedApprovalResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
