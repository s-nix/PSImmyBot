using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "User")]
public class NewUser : Cmdlet {
    [Parameter(Mandatory = true)] public required int AccessFailedCount { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AccessRequest>? AccessRequestAcknowledgements { get; set; }
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required bool CanManageCrossTenantDeployments { get; set; }
    [Parameter(Mandatory = false)] public string? ConcurrencyStamp { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Branding>? CreatedBrandings { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequestComment>? CreatedChangeRequestComments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequest>? CreatedChangeRequests { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TargetAssignment>? CreatedDeployments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<License>? CreatedLicenses { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceSession>? CreatedMaintenanceSessions { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceTask>? CreatedMaintenanceTasks { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Media>? CreatedMedia { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Person>? CreatedPersons { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderLink>? CreatedProviderLinks { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RecommendedTargetAssignmentApproval>? CreatedRecommendedTargetAssignmentApprovals { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Schedule>? CreatedSchedules { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Script>? CreatedScripts { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LocalSoftware>? CreatedSoftware { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LocalSoftwareVersion>? CreatedSoftwareVersions { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Tag>? CreatedTags { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AuditPropertyChange>? CustomAuditProperties { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? Email { get; set; }
    [Parameter(Mandatory = true)] public required bool EmailConfirmed { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? ExpirationDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool HasManagementAccess { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UserImpersonation>? ImpersonatedByUsers { get; set; }
    [Parameter(Mandatory = true)] public required User ImpersonatorUser { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAdmin { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSupportTechnician { get; set; }
    [Parameter(Mandatory = true)] public required bool LockoutEnabled { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? LockoutEnd { get; set; }
    [Parameter(Mandatory = false)] public string? NormalizedEmail { get; set; }
    [Parameter(Mandatory = false)] public string? NormalizedUserName { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public string? PasswordHash { get; set; }
    [Parameter(Mandatory = true)] public required Person Person { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public string? PhoneNumber { get; set; }
    [Parameter(Mandatory = true)] public required bool PhoneNumberConfirmed { get; set; }
    [Parameter(Mandatory = false)] public string? SecurityStamp { get; set; }
    [Parameter(Mandatory = false)] public string? ServicePrincipalId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UserSilencedNotification>? SilencedNotifications { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = true)] public required bool TwoFactorEnabled { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Branding>? UpdatedBrandings { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequestComment>? UpdatedChangeRequestComments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequest>? UpdatedChangeRequests { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TargetAssignment>? UpdatedDeployments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<License>? UpdatedLicenses { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceTask>? UpdatedMaintenanceTasks { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Media>? UpdatedMedia { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Person>? UpdatedPersons { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderLink>? UpdatedProviderLinks { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RecommendedTargetAssignmentApproval>? UpdatedRecommendedTargetAssignmentApprovals { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Schedule>? UpdatedSchedules { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Script>? UpdatedScripts { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LocalSoftware>? UpdatedSoftware { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LocalSoftwareVersion>? UpdatedSoftwareVersions { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Tag>? UpdatedTags { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UserImpersonation>? UserImpersonations { get; set; }
    [Parameter(Mandatory = false)] public string? UserName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UserRole>? UserRoles { get; set; }

    protected override void ProcessRecord() {
        User outputObject = new(AccessFailedCount, AccessRequestAcknowledgements, AzurePrincipalId, CanManageCrossTenantDeployments, ConcurrencyStamp, CreatedBrandings, CreatedBy, CreatedChangeRequestComments, CreatedChangeRequests, CreatedDate, CreatedDeployments, CreatedLicenses, CreatedMaintenanceSessions, CreatedMaintenanceTasks, CreatedMedia, CreatedPersons, CreatedProviderLinks, CreatedRecommendedTargetAssignmentApprovals, CreatedSchedules, CreatedScripts, CreatedSoftware, CreatedSoftwareVersions, CreatedTags, CustomAuditProperties, DisplayName, Email, EmailConfirmed, ExpirationDateUtc, HasManagementAccess, Id, ImpersonatedByUsers, ImpersonatorUser, IsAdmin, IsSupportTechnician, LockoutEnabled, LockoutEnd, NormalizedEmail, NormalizedUserName, OwnerTenant, PasswordHash, Person, PersonId, PhoneNumber, PhoneNumberConfirmed, SecurityStamp, ServicePrincipalId, SilencedNotifications, TenantId, TwoFactorEnabled, UpdatedBrandings, UpdatedBy, UpdatedChangeRequestComments, UpdatedChangeRequests, UpdatedDate, UpdatedDeployments, UpdatedLicenses, UpdatedMaintenanceTasks, UpdatedMedia, UpdatedPersons, UpdatedProviderLinks, UpdatedRecommendedTargetAssignmentApprovals, UpdatedSchedules, UpdatedScripts, UpdatedSoftware, UpdatedSoftwareVersions, UpdatedTags, UserImpersonations, UserName, UserRoles);
        WriteObject(outputObject);
    }
}
