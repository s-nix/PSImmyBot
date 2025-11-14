using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderAgent")]
public class NewProviderAgent : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalAgentId { get; set; }
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }
    [Parameter(Mandatory = true)] public required bool SupportsOnlineStatus { get; set; }
    [Parameter(Mandatory = true)] public required bool SupportsRunningScripts { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion AgentVersion { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateAddedUtc { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset LastUpdatedUtc { get; set; }
    [Parameter(Mandatory = false)] public object? InternalData { get; set; }
    [Parameter(Mandatory = true)] public required DeviceDetails DeviceDetails { get; set; }
    [Parameter(Mandatory = true)] public required AgentOnboardingOptions OnboardingOptions { get; set; }
    [Parameter(Mandatory = true)] public required bool RequireManualIdentification { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLink ProviderLink { get; set; }
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = true)] public required ProviderClient ProviderClient { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AgentIdentificationFailure>? IdentificationFailures { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AgentIdentificationLog>? IdentificationLogs { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMemberOfInitialDeviceSync { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DeletedAt { get; set; }
    [Parameter(Mandatory = false)] public string? DeletedReason { get; set; }

    protected override void ProcessRecord() {
        ProviderAgent outputObject = new(Id, ProviderLinkId, ExternalClientId, ExternalAgentId, ComputerId, IsOnline, SupportsOnlineStatus, SupportsRunningScripts, AgentVersion, DateAddedUtc, LastUpdatedUtc, InternalData, DeviceDetails, OnboardingOptions, RequireManualIdentification, ProviderLink, Computer, ProviderClient, IdentificationFailures, IdentificationLogs, IsMemberOfInitialDeviceSync, DeletedAt, DeletedReason);
        WriteObject(outputObject);
    }
}
