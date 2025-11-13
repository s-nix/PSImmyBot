using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "PendingCounts")]
public class GetPendingCounts : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/provider-agents/pending-counts?";

        GetPendingCountsResponse response = ImmyBotApiService.Get<GetPendingCountsResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
