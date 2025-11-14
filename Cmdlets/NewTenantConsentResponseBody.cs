using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantConsentResponseBody")]
public class NewTenantConsentResponseBody : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsPartner { get; set; }
    [Parameter(Mandatory = false)] public string? TenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        TenantConsentResponseBody outputObject = new(IsPartner, TenantPrincipalId);
        WriteObject(outputObject);
    }
}
