using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateOrUpdateRoleRequest")]
public class NewCreateOrUpdateRoleRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? GrantedPermissionIds { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        CreateOrUpdateRoleRequest outputObject = new(Description, GrantedPermissionIds, Name);
        WriteObject(outputObject);
    }
}
