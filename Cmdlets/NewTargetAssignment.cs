using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TargetAssignment")]
public class NewTargetAssignment : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required bool AutoApprove { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequest>? ChangeRequests { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = true)] public required bool Excluded { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? IntegrationPrompt { get; set; }
    [Parameter(Mandatory = false)] public string? IntegrationTypeId { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCore { get; set; }
    [Parameter(Mandatory = true)] public required License License { get; set; }
    [Parameter(Mandatory = false)] public int? LicenseId { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSpecifier MaintenanceSpecifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceTaskParameterValue>? MaintenanceTaskParameterValues { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = true)] public required TargetAssignmentNotes Notes { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingOnly { get; set; }
    [Parameter(Mandatory = false)] public string? ParameterValueMigrationErrors { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderClientGroupType { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProviderDeviceGroupType { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLink ProviderLink { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkIdForMaintenanceItem { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareId { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareProviderType SoftwareProviderType { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SoftwareSemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareSemanticVersionString { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareSpecifier SoftwareSpecifier { get; set; }
    [Parameter(Mandatory = true)] public required int SoftwareVersionId { get; set; }
    [Parameter(Mandatory = true)] public required int SortOrder { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required TargetCategory TargetCategory { get; set; }
    [Parameter(Mandatory = true)] public required TargetEnforcement TargetEnforcement { get; set; }
    [Parameter(Mandatory = true)] public required TargetGroupFilter TargetGroupFilter { get; set; }
    [Parameter(Mandatory = false)] public string? TargetName { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, DeploymentParameterValue>? TaskParameterValues { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required TargetAssignmentVisibility Visibility { get; set; }

    protected override void ProcessRecord() {
        TargetAssignment outputObject = new(AllowAccessToParentTenant, AutoApprove, ChangeRequests, CreatedBy, CreatedByUser, CreatedDate, DatabaseType, DesiredSoftwareState, Excluded, Id, IntegrationPrompt, IntegrationTypeId, IsCore, License, LicenseId, MaintenanceIdentifier, MaintenanceSpecifier, MaintenanceTaskMode, MaintenanceTaskParameterValues, MaintenanceType, Notes, OnboardingOnly, ParameterValueMigrationErrors, PropagateToChildTenants, ProviderClientGroupType, ProviderDeviceGroupType, ProviderLink, ProviderLinkId, ProviderLinkIdForMaintenanceItem, SoftwareId, SoftwareProviderType, SoftwareSemanticVersion, SoftwareSemanticVersionString, SoftwareSpecifier, SoftwareVersionId, SortOrder, Target, TargetCategory, TargetEnforcement, TargetGroupFilter, TargetName, TargetType, TaskParameterValues, TenantId, UpdatedBy, UpdatedByUser, UpdatedDate, Visibility);
        WriteObject(outputObject);
    }
}
