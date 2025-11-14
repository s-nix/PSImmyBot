using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateTenantRequestBody")]
public class NewCreateTenantRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsMsp { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? LimitToDomains { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required int OwnerTenantId { get; set; }
    [Parameter(Mandatory = false)] public int? ParentTenantId { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? Slug { get; set; }

    protected override void ProcessRecord() {
        CreateTenantRequestBody outputObject = new(IsMsp, LimitToDomains, Name, OwnerTenantId, ParentTenantId, PartnerPrincipalId, PrincipalId, Slug);
        WriteObject(outputObject);
    }
}
