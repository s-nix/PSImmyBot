using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateAzureTenantAuthDetailsCmdPayload")]
public class NewUpdateAzureTenantAuthDetailsCmdPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required AzureTenantAuthDetails AuthDetails { get; set; }

    protected override void ProcessRecord() {
        UpdateAzureTenantAuthDetailsCmdPayload outputObject = new(AuthDetails);
        WriteObject(outputObject);
    }
}
