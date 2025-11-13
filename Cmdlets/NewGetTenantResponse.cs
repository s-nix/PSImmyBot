using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetTenantResponse")]
public class NewGetTenantResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Active { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantLinkResponse AzureTenantLink { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMsp { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? MarkedForDeletionAtUtc { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public int? OwnerTenantId { get; set; }
    [Parameter(Mandatory = false)] public int? ParentTenantId { get; set; }
    [Parameter(Mandatory = false)] public string? Slug { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? TenantTagIds { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? TenantTagNames { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetTenantResponse outputObject = new(Active, AzureTenantLink, CreatedBy, CreatedDateUtc, Id, IsMsp, MarkedForDeletionAtUtc, Name, OwnerTenantId, ParentTenantId, Slug, TenantTagIds, TenantTagNames, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
