using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkCreateTenantRequestBodyListItem")]
public class NewBulkCreateTenantRequestBodyListItem : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? LimitToDomains { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? Slug { get; set; }

    protected override void ProcessRecord() {
        BulkCreateTenantRequestBodyListItem outputObject = new(LimitToDomains, Name, PartnerPrincipalId, PrincipalId, Slug);
        WriteObject(outputObject);
    }
}
