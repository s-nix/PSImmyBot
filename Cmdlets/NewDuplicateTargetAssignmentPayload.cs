using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DuplicateTargetAssignmentPayload")]
public class NewDuplicateTargetAssignmentPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = true)] public required bool Excluded { get; set; }
    [Parameter(Mandatory = false)] public int? Id { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderClientGroupType { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderDeviceGroupType { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkIdForMaintenanceItem { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareProviderType SoftwareProviderType { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SoftwareSemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required TargetCategory TargetCategory { get; set; }
    [Parameter(Mandatory = true)] public required TargetEnforcement TargetEnforcement { get; set; }
    [Parameter(Mandatory = true)] public required TargetGroupFilter TargetGroupFilter { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, DeploymentParameterValue>? TaskParameterValues { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }

    protected override void ProcessRecord() {
        DuplicateTargetAssignmentPayload outputObject = new(AllowAccessToParentTenant, DesiredSoftwareState, Excluded, Id, MaintenanceIdentifier, MaintenanceTaskMode, MaintenanceType, Notes, OnboardingOnly, PropagateToChildTenants, ProviderClientGroupType, ProviderDeviceGroupType, ProviderLinkId, ProviderLinkIdForMaintenanceItem, SoftwareProviderType, SoftwareSemanticVersion, Target, TargetCategory, TargetEnforcement, TargetGroupFilter, TargetType, TaskParameterValues, TenantId);
        WriteObject(outputObject);
    }
}
