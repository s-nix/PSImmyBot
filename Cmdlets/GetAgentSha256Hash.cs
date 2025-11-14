using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AgentSha256Hash")]
public class GetAgentSha256Hash : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/immy-agent-metadata/agent-hash?";

        GetAgentSha256HashResponse response = ImmyBotApiService.Get<GetAgentSha256HashResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
