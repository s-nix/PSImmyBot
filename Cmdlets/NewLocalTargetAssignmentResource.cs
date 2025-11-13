using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LocalTargetAssignmentResource")]
public class NewLocalTargetAssignmentResource : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = true)] public required bool Excluded { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? IntegrationPrompt { get; set; }
    [Parameter(Mandatory = false)] public string? IntegrationTypeId { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCore { get; set; }
    [Parameter(Mandatory = false)] public int? LicenseId { get; set; }
    [Parameter(Mandatory = false)] public string? LicenseName { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = false)] public string? NotesUpdatedByUserName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? NotesUpdatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderClientGroupType { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderDeviceGroupType { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkIdForMaintenanceItem { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareProviderType SoftwareProviderType { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SoftwareSemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareSemanticVersionString { get; set; }
    [Parameter(Mandatory = true)] public required int SortOrder { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required TargetCategory TargetCategory { get; set; }
    [Parameter(Mandatory = true)] public required TargetEnforcement TargetEnforcement { get; set; }
    [Parameter(Mandatory = true)] public required TargetGroupFilter TargetGroupFilter { get; set; }
    [Parameter(Mandatory = false)] public string? TargetGroupFilterName { get; set; }
    [Parameter(Mandatory = true)] public required bool TargetMissing { get; set; }
    [Parameter(Mandatory = false)] public string? TargetName { get; set; }
    [Parameter(Mandatory = false)] public string? TargetScopeName { get; set; }
    [Parameter(Mandatory = false)] public string? TargetText { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public string? TargetTypeDescription { get; set; }
    [Parameter(Mandatory = true)] public required bool TargetTypeMissing { get; set; }
    [Parameter(Mandatory = false)] public string? TargetTypeName { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, DeploymentParameterValue>? TaskParameterValues { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = true)] public required bool TenantMissing { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required TargetAssignmentVisibilityResource Visibility { get; set; }

    protected override void ProcessRecord() {
        LocalTargetAssignmentResource outputObject = new(AllowAccessToParentTenant, CreatedDateUtc, DatabaseType, DesiredSoftwareState, Excluded, Id, IntegrationPrompt, IntegrationTypeId, IsCore, LicenseId, LicenseName, MaintenanceIdentifier, MaintenanceTaskMode, MaintenanceType, Notes, NotesUpdatedByUserName, NotesUpdatedUtc, OnboardingOnly, PropagateToChildTenants, ProviderClientGroupType, ProviderDeviceGroupType, ProviderLinkId, ProviderLinkIdForMaintenanceItem, SoftwareProviderType, SoftwareSemanticVersion, SoftwareSemanticVersionString, SortOrder, Target, TargetCategory, TargetEnforcement, TargetGroupFilter, TargetGroupFilterName, TargetMissing, TargetName, TargetScopeName, TargetText, TargetType, TargetTypeDescription, TargetTypeMissing, TargetTypeName, TaskParameterValues, TenantId, TenantMissing, UpdatedBy, UpdatedDateUtc, Visibility);
        WriteObject(outputObject);
    }
}
