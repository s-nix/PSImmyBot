using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantConsentDetails")]
public class NewAzureTenantConsentDetails : Cmdlet {
    [Parameter(Mandatory = false)] public DateTimeOffset? ConsentDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required AppRegistrationType ConsentedWith { get; set; }

    protected override void ProcessRecord() {
        AzureTenantConsentDetails outputObject = new(ConsentDateUtc, ConsentedWith);
        WriteObject(outputObject);
    }
}
