using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantSoftware")]
public class NewTenantSoftware : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required LocalSoftware Software { get; set; }
    [Parameter(Mandatory = true)] public required int SoftwareId { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        TenantSoftware outputObject = new(CreatedBy, CreatedDate, Software, SoftwareId, Tenant, TenantId, UpdatedBy, UpdatedDate);
        WriteObject(outputObject);
    }
}
