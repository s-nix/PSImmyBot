using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GrantAccessRequestRbac")]
public class NewGrantAccessRequestRbac : Cmdlet {
    [Parameter(Mandatory = true)] public required ExpirationTime ExpiresIn { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? PersonIds { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? RoleIds { get; set; }

    protected override void ProcessRecord() {
        GrantAccessRequestRbac outputObject = new(ExpiresIn, PersonIds, RoleIds);
        WriteObject(outputObject);
    }
}
