using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RemoveParentTenantRequest")]
public class NewRemoveParentTenantRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required int ParentTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? TenantIds { get; set; }

    protected override void ProcessRecord() {
        RemoveParentTenantRequest outputObject = new(ParentTenantId, TenantIds);
        WriteObject(outputObject);
    }
}
