using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantTagAuthorization")]
public class NewTenantTagAuthorization : Cmdlet {
    [Parameter(Mandatory = true)] public required Relationship Relationship { get; set; }
    [Parameter(Mandatory = true)] public required Tag Tag { get; set; }
    [Parameter(Mandatory = true)] public required int TagId { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        TenantTagAuthorization outputObject = new(Relationship, Tag, TagId, Tenant, TenantId);
        WriteObject(outputObject);
    }
}
