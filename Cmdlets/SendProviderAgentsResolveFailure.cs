using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ProviderAgentsResolveFailure")]
public class SendProviderAgentsResolveFailure : Cmdlet {
    [Parameter(Mandatory = true)] public int FailureId { get; set; }
    [Parameter(Mandatory = false)] public AgentIdentificationManualResolutionDecision ManualResolutionDecision { get; set; }
    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-agents/resolve-failure/{FailureId}";
        endpoint += Globals.ConvertToQueryParameters(ManualResolutionDecision, "manualResolutionDecision");
        
        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }
}
