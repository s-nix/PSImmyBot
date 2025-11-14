using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateAzureTenantAuthDetailsCmdResult")]
public class NewUpdateAzureTenantAuthDetailsCmdResult : Cmdlet {
    [Parameter(Mandatory = true)] public required AzureTenantAuthDetails AuthDetails { get; set; }
    [Parameter(Mandatory = true)] public required bool DefaultAppRegistrationUpdated { get; set; }

    protected override void ProcessRecord() {
        UpdateAzureTenantAuthDetailsCmdResult outputObject = new(AuthDetails, DefaultAppRegistrationUpdated);
        WriteObject(outputObject);
    }
}
