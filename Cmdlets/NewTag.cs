using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Tag")]
public class NewTag : Cmdlet {
    [Parameter(Mandatory = false)] public string? Color { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Computer>? Computers { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ComputerTag>? ComputerTags { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Person>? Persons { get; set; }
    [Parameter(Mandatory = false)] public ICollection<PersonTag>? PersonTags { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantTagAuthorization>? TenantRelationships { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Tenant>? Tenants { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantTag>? TenantTags { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        Tag outputObject = new(Color, Computers, ComputerTags, CreatedBy, CreatedByUser, CreatedDate, Description, Id, Name, Persons, PersonTags, TenantRelationships, Tenants, TenantTags, UpdatedBy, UpdatedByUser, UpdatedDate);
        WriteObject(outputObject);
    }
}
