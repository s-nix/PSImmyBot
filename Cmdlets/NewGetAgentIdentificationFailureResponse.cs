using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetAgentIdentificationFailureResponse")]
public class NewGetAgentIdentificationFailureResponse : Cmdlet {
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required IProviderAgentDetails ExistingAgent { get; set; }
    [Parameter(Mandatory = false)] public int? ExistingAgentId { get; set; }
    [Parameter(Mandatory = false)] public string? ExistingComputerName { get; set; }
    [Parameter(Mandatory = false)] public string? ExistingManufacturer { get; set; }
    [Parameter(Mandatory = false)] public string? ExistingOperatingSystem { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? ExistingOsInstallDate { get; set; }
    [Parameter(Mandatory = false)] public string? ExistingPrimaryUserFirstName { get; set; }
    [Parameter(Mandatory = false)] public string? ExistingPrimaryUserLastName { get; set; }
    [Parameter(Mandatory = false)] public string? ExistingSerialNumber { get; set; }
    [Parameter(Mandatory = false)] public string? ExistingTenantName { get; set; }
    [Parameter(Mandatory = true)] public required bool FeatureUsageExceeded { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required AgentIdentificationManualResolutionDecision ManualResolutionDecision { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = false)] public int? PendingAgentId { get; set; }
    [Parameter(Mandatory = true)] public required bool RequiresManualResolution { get; set; }
    [Parameter(Mandatory = true)] public required bool Resolved { get; set; }

    protected override void ProcessRecord() {
        GetAgentIdentificationFailureResponse outputObject = new(ComputerId, CreatedDateUtc, ExistingAgent, ExistingAgentId, ExistingComputerName, ExistingManufacturer, ExistingOperatingSystem, ExistingOsInstallDate, ExistingPrimaryUserFirstName, ExistingPrimaryUserLastName, ExistingSerialNumber, ExistingTenantName, FeatureUsageExceeded, Id, ManualResolutionDecision, Message, PendingAgentId, RequiresManualResolution, Resolved);
        WriteObject(outputObject);
    }
}
