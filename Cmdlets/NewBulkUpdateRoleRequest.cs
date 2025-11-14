using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkUpdateRoleRequest")]
public class NewBulkUpdateRoleRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? PersonIds { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? RoleIds { get; set; }

    protected override void ProcessRecord() {
        BulkUpdateRoleRequest outputObject = new(PersonIds, RoleIds);
        WriteObject(outputObject);
    }
}
