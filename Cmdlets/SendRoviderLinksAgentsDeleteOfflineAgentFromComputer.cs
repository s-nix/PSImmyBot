using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RoviderLinksAgentsDeleteOfflineAgentFromComputer")]
public class SendRoviderLinksAgentsDeleteOfflineAgentFromComputer : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

     [Parameter(Mandatory = true)]
    public int AgentId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/agents/{AgentId}/delete-offline-agent-from-computer?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
