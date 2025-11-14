using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DisambiguateAzureTenantTypeRequestBody")]
public class NewDisambiguateAzureTenantTypeRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? TenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        DisambiguateAzureTenantTypeRequestBody outputObject = new(TenantPrincipalId);
        WriteObject(outputObject);
    }
}
