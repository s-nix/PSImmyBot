using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetProviderAgentIdentificationLogResponse")]
public class GetGetProviderAgentIdentificationLogResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int AgentId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-agents/{AgentId}/identification-logs?";

        List<GetProviderAgentIdentificationLogResponse> response = ImmyBotApiService.Get<List<GetProviderAgentIdentificationLogResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
