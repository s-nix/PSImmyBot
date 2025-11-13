using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AgentIdentificationFailure")]
public class NewAgentIdentificationFailure : Cmdlet {
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public int? ExistingAgentId { get; set; }
    [Parameter(Mandatory = true)] public required bool FeatureUsageExceeded { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required AgentIdentificationManualResolutionDecision ManualResolutionDecision { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required ProviderAgent PendingAgent { get; set; }
    [Parameter(Mandatory = true)] public required int PendingAgentId { get; set; }
    [Parameter(Mandatory = true)] public required bool RequiresManualResolution { get; set; }
    [Parameter(Mandatory = true)] public required bool Resolved { get; set; }
    [Parameter(Mandatory = true)] public required bool UnsupportedDeviceType { get; set; }

    protected override void ProcessRecord() {
        AgentIdentificationFailure outputObject = new(Computer, ComputerId, CreatedDateUtc, ExistingAgentId, FeatureUsageExceeded, Id, ManualResolutionDecision, Message, PendingAgent, PendingAgentId, RequiresManualResolution, Resolved, UnsupportedDeviceType);
        WriteObject(outputObject);
    }
}
