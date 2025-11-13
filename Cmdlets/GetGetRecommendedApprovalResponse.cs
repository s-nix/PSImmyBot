using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetRecommendedApprovalResponse")]
public class GetGetRecommendedApprovalResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/recommended-approvals?";

        List<GetRecommendedApprovalResponse> response = ImmyBotApiService.Get<List<GetRecommendedApprovalResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
