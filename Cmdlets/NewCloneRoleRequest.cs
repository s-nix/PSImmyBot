using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CloneRoleRequest")]
public class NewCloneRoleRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? NewName { get; set; }

    protected override void ProcessRecord() {
        CloneRoleRequest outputObject = new(NewName);
        WriteObject(outputObject);
    }
}
