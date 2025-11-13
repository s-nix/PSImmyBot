using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantMedia")]
public class NewTenantMedia : Cmdlet {
    [Parameter(Mandatory = true)] public required Media Media { get; set; }
    [Parameter(Mandatory = true)] public required int MediaId { get; set; }
    [Parameter(Mandatory = true)] public required Relationship Relationship { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        TenantMedia outputObject = new(Media, MediaId, Relationship, Tenant, TenantId);
        WriteObject(outputObject);
    }
}
