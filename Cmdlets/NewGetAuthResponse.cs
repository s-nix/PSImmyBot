using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetAuthResponse")]
public class NewGetAuthResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<SubscriptionAddonDto>? Addons { get; set; }
    [Parameter(Mandatory = false)] public string? BackendRegAppId { get; set; }
    [Parameter(Mandatory = true)] public required bool CanManageCrossTenantDeployments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ClaimResponse>? Claims { get; set; }
    [Parameter(Mandatory = true)] public required ReleaseChannel CurrentReleaseReleaseChannel { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion CurrentReleaseVersion { get; set; }
    [Parameter(Mandatory = false)] public int? DaysLeftInTrial { get; set; }
    [Parameter(Mandatory = true)] public required DevInstanceDetails DevInstanceDetails { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? Email { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Feature>? Features { get; set; }
    [Parameter(Mandatory = false)] public string? FirstName { get; set; }
    [Parameter(Mandatory = false)] public string? GlobalPublicMediaContainerName { get; set; }
    [Parameter(Mandatory = false)] public string? GlobalSoftwareEndpoint { get; set; }
    [Parameter(Mandatory = true)] public required bool HasManagementAccess { get; set; }
    [Parameter(Mandatory = false)] public string? ImmyProduct { get; set; }
    [Parameter(Mandatory = true)] public required bool Impersonating { get; set; }
    [Parameter(Mandatory = true)] public required ReleaseChannel InstanceReleaseChannel { get; set; }
    [Parameter(Mandatory = true)] public required bool InstanceUpdateHasFailed { get; set; }
    [Parameter(Mandatory = false)] public string? InstanceUpdateSource { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAdmin { get; set; }
    [Parameter(Mandatory = true)] public required bool IsImmense { get; set; }
    [Parameter(Mandatory = true)] public required bool IsImmySupportAccessEnabled { get; set; }
    [Parameter(Mandatory = true)] public required bool IsInstanceRestarting { get; set; }
    [Parameter(Mandatory = true)] public required bool IsInstanceUpdating { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMsp { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSupportTechnician { get; set; }
    [Parameter(Mandatory = false)] public string? LastName { get; set; }
    [Parameter(Mandatory = false)] public string? LocalPublicMediaContainerName { get; set; }
    [Parameter(Mandatory = false)] public string? LocalSoftwareEndpoint { get; set; }
    [Parameter(Mandatory = false)] public int? MaximumTrackableComputers { get; set; }
    [Parameter(Mandatory = true)] public required int MaxRunningSessionCount { get; set; }
    [Parameter(Mandatory = true)] public required int OpenAccessRequestCount { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public string? PlanId { get; set; }
    [Parameter(Mandatory = false)] public int? PlanPrice { get; set; }
    [Parameter(Mandatory = false)] public int? PlanQuantity { get; set; }
    [Parameter(Mandatory = true)] public required SubscriptionStatus Status { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? TrialEndUtc { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? TrialStartUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool UpdateAvailable { get; set; }
    [Parameter(Mandatory = true)] public required int UserId { get; set; }
    [Parameter(Mandatory = true)] public required bool UserLevelAuthSelected { get; set; }

    protected override void ProcessRecord() {
        GetAuthResponse outputObject = new(Addons, BackendRegAppId, CanManageCrossTenantDeployments, Claims, CurrentReleaseReleaseChannel, CurrentReleaseVersion, DaysLeftInTrial, DevInstanceDetails, DisplayName, Email, Features, FirstName, GlobalPublicMediaContainerName, GlobalSoftwareEndpoint, HasManagementAccess, ImmyProduct, Impersonating, InstanceReleaseChannel, InstanceUpdateHasFailed, InstanceUpdateSource, IsAdmin, IsImmense, IsImmySupportAccessEnabled, IsInstanceRestarting, IsInstanceUpdating, IsMsp, IsSupportTechnician, LastName, LocalPublicMediaContainerName, LocalSoftwareEndpoint, MaximumTrackableComputers, MaxRunningSessionCount, OpenAccessRequestCount, PersonId, PlanId, PlanPrice, PlanQuantity, Status, TenantId, TenantName, TrialEndUtc, TrialStartUtc, UpdateAvailable, UserId, UserLevelAuthSelected);
        WriteObject(outputObject);
    }
}
