using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeleteAzureTenantAuthDetailsCmdResult")]
public class NewDeleteAzureTenantAuthDetailsCmdResult : Cmdlet {
    [Parameter(Mandatory = true)] public required bool DefaultAppRegistrationUpdated { get; set; }

    protected override void ProcessRecord() {
        DeleteAzureTenantAuthDetailsCmdResult outputObject = new(DefaultAppRegistrationUpdated);
        WriteObject(outputObject);
    }
}
