using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantConsentRequestBody")]
public class NewTenantConsentRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required AppRegistrationType AppType { get; set; }
    [Parameter(Mandatory = false)] public string? TenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        TenantConsentRequestBody outputObject = new(AppType, TenantPrincipalId);
        WriteObject(outputObject);
    }
}
