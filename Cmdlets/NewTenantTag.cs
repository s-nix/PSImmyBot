using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantTag")]
public class NewTenantTag : Cmdlet {
    [Parameter(Mandatory = true)] public required int EntityId { get; set; }
    [Parameter(Mandatory = true)] public required Tag Tag { get; set; }
    [Parameter(Mandatory = true)] public required int TagId { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }

    protected override void ProcessRecord() {
        TenantTag outputObject = new(EntityId, Tag, TagId, Tenant);
        WriteObject(outputObject);
    }
}
