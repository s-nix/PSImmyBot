using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetFailedPendingAgentResponse")]
public class GetGetFailedPendingAgentResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-agents/{ComputerId}/pending-conflicts?";

        List<GetFailedPendingAgentResponse> response = ImmyBotApiService.Get<List<GetFailedPendingAgentResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
