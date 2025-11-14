using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeleteAzureTenantAuthDetailsCmdPayload")]
public class NewDeleteAzureTenantAuthDetailsCmdPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzureTenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        DeleteAzureTenantAuthDetailsCmdPayload outputObject = new(AzureTenantPrincipalId);
        WriteObject(outputObject);
    }
}
