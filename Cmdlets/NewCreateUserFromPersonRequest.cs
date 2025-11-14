using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateUserFromPersonRequest")]
public class NewCreateUserFromPersonRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool HasManagementAccess { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }

    protected override void ProcessRecord() {
        CreateUserFromPersonRequest outputObject = new(HasManagementAccess, PersonId);
        WriteObject(outputObject);
    }
}
