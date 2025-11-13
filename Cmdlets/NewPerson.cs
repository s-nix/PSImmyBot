using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Person")]
public class NewPerson : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<AccessRequest>? AccessRequests { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ComputerPerson>? AdditionalComputers { get; set; }
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<DetectedComputerSoftware>? DetectedComputerSoftware { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? EmailAddress { get; set; }
    [Parameter(Mandatory = false)] public string? FirstName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? LastName { get; set; }
    [Parameter(Mandatory = false)] public string? OnPremisesSecurityIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceSession>? PersonSessions { get; set; }
    [Parameter(Mandatory = false)] public ICollection<PersonTag>? PersonTags { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Computer>? PrimaryComputers { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Tag>? Tags { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required User User { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UserAffinity>? UserAffinities { get; set; }

    protected override void ProcessRecord() {
        Person outputObject = new(AccessRequests, AdditionalComputers, AzurePrincipalId, CreatedBy, CreatedByUser, CreatedDate, DetectedComputerSoftware, DisplayName, EmailAddress, FirstName, Id, LastName, OnPremisesSecurityIdentifier, OwnerTenant, PersonSessions, PersonTags, PrimaryComputers, Tags, TenantId, UpdatedBy, UpdatedByUser, UpdatedDate, User, UserAffinities);
        WriteObject(outputObject);
    }
}
