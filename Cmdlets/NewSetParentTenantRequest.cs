using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SetParentTenantRequest")]
public class NewSetParentTenantRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required int ParentTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? TenantIds { get; set; }

    protected override void ProcessRecord() {
        SetParentTenantRequest outputObject = new(ParentTenantId, TenantIds);
        WriteObject(outputObject);
    }
}
