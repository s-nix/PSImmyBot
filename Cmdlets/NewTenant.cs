using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Tenant")]
public class NewTenant : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Active { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantLink AzureTenantLink { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Branding>? Brandings { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Computer>? Computers { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<DetectedComputerSoftware>? DetectedComputerSoftware { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMsp { get; set; }
    [Parameter(Mandatory = false)] public ICollection<License>? Licenses { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceSession>? MaintenanceSessions { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantMaintenanceTask>? MaintenanceTasks { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? MarkedForDeletionAtUtc { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantMedia>? Media { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderLink>? OwnedProviderLinks { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Tenant>? OwnedTenants { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public int? ParentTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Person>? Persons { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderClient>? ProviderClients { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Schedule>? Schedules { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantScript>? Scripts { get; set; }
    [Parameter(Mandatory = false)] public string? Slug { get; set; }
    [Parameter(Mandatory = true)] public required SmtpConfig SmtpConfig { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Tag>? Tags { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = true)] public required TenantPreferences TenantPreferences { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantSoftware>? TenantSoftware { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantTagAuthorization>? TenantTagAuthorizations { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantTag>? TenantTags { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<User>? Users { get; set; }

    protected override void ProcessRecord() {
        Tenant outputObject = new(Active, AzureTenantLink, Brandings, Computers, CreatedBy, CreatedDate, DetectedComputerSoftware, Id, IsMsp, Licenses, MaintenanceSessions, MaintenanceTasks, MarkedForDeletionAtUtc, Media, Name, OwnedProviderLinks, OwnedTenants, OwnerTenant, ParentTenantId, Persons, ProviderClients, Schedules, Scripts, Slug, SmtpConfig, Tags, TenantId, TenantPreferences, TenantSoftware, TenantTagAuthorizations, TenantTags, UpdatedBy, UpdatedDate, Users);
        WriteObject(outputObject);
    }
}
