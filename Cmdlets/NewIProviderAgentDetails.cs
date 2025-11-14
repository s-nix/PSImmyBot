using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IProviderAgentDetails")]
public class NewIProviderAgentDetails : Cmdlet {
    [Parameter(Mandatory = true)] public required SemanticVersion AgentVersion { get; set; }
    [Parameter(Mandatory = true)] public required DeviceDetails DeviceDetails { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalAgentId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientId { get; set; }
    [Parameter(Mandatory = false)] public object? InternalData { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset LastUpdatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required AgentOnboardingOptions OnboardingOptions { get; set; }
    [Parameter(Mandatory = true)] public required bool RequireManualIdentification { get; set; }
    [Parameter(Mandatory = true)] public required bool SupportsRunningScripts { get; set; }

    protected override void ProcessRecord() {
        IProviderAgentDetails outputObject = new(AgentVersion, DeviceDetails, ExternalAgentId, ExternalClientId, InternalData, IsOnline, LastUpdatedUtc, OnboardingOptions, RequireManualIdentification, SupportsRunningScripts);
        WriteObject(outputObject);
    }
}
