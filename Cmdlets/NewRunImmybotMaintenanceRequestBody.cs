using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunImmybotMaintenanceRequestBody")]
public class NewRunImmybotMaintenanceRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkIdForMaintenanceItem { get; set; }
    [Parameter(Mandatory = true)] public required bool Repair { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SemanticVersionNormalized { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareProviderType SoftwareProviderType { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, DeploymentParameterValue>? TaskParameterValues { get; set; }

    protected override void ProcessRecord() {
        RunImmybotMaintenanceRequestBody outputObject = new(DesiredSoftwareState, MaintenanceIdentifier, MaintenanceTaskMode, MaintenanceType, ProviderLinkIdForMaintenanceItem, Repair, SemanticVersion, SemanticVersionNormalized, SoftwareProviderType, SoftwareType, TaskParameterValues);
        WriteObject(outputObject);
    }
}
