using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetProviderAgentResponse")]
public class NewGetProviderAgentResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required SemanticVersion AgentVersion { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required DeviceDetails DeviceDetails { get; set; }
    [Parameter(Mandatory = false)] public object? DeviceUpdateFormData { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalAgentId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public object? InternalData { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset LastUpdatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required AgentOnboardingOptions OnboardingOptions { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }
    [Parameter(Mandatory = true)] public required bool RequireManualIdentification { get; set; }
    [Parameter(Mandatory = true)] public required int RunScriptPriority { get; set; }
    [Parameter(Mandatory = true)] public required bool SupportsRunningScripts { get; set; }

    protected override void ProcessRecord() {
        GetProviderAgentResponse outputObject = new(AgentVersion, ComputerId, DeviceDetails, DeviceUpdateFormData, ExternalAgentId, ExternalClientId, ExternalClientName, Id, InternalData, IsOnline, LastUpdatedUtc, OnboardingOptions, ProviderLinkId, ProviderTypeId, RequireManualIdentification, RunScriptPriority, SupportsRunningScripts);
        WriteObject(outputObject);
    }
}
