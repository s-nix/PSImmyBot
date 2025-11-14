using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RoviderAgentsResolveFailures")]
public class SendRoviderAgentsResolveFailures : Cmdlet {
    [Parameter(Mandatory = true)]
    public int AgentId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-agents/{AgentId}/resolve-failures?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
