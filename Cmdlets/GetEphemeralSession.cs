using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "EphemeralSession")]
public class GetEphemeralSession : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string EphemeralSessionId { get; set; }

    [Parameter(Mandatory = true)]
    public required string AgentInstanceId { get; set; }

    [Parameter(Mandatory = true)]
    public int ProviderAgentId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/ephemeral-session/{EphemeralSessionId}/{AgentInstanceId}/{ProviderAgentId}?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
