using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AgentStatusDto")]
public class NewAgentStatusDto : Cmdlet {
    [Parameter(Mandatory = true)] public required int AgentId { get; set; }
    [Parameter(Mandatory = true)] public required bool IsConnected { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset LastUpdatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion Version { get; set; }

    protected override void ProcessRecord() {
        AgentStatusDto outputObject = new(AgentId, IsConnected, LastUpdatedUtc, ProviderLinkId, Version);
        WriteObject(outputObject);
    }
}
