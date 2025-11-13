using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MergeTenantsPayload")]
public class NewMergeTenantsPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required int TargetTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? TenantsToMerge { get; set; }

    protected override void ProcessRecord() {
        MergeTenantsPayload outputObject = new(TargetTenantId, TenantsToMerge);
        WriteObject(outputObject);
    }
}
