using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GrantAccessRequest")]
public class NewGrantAccessRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required ExpirationTime ExpirationTime { get; set; }
    [Parameter(Mandatory = true)] public required bool HasManagementAccess { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAdmin { get; set; }

    protected override void ProcessRecord() {
        GrantAccessRequest outputObject = new(ExpirationTime, HasManagementAccess, IsAdmin);
        WriteObject(outputObject);
    }
}
