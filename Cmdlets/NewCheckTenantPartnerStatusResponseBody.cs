using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CheckTenantPartnerStatusResponseBody")]
public class NewCheckTenantPartnerStatusResponseBody : Cmdlet {
    [Parameter(Mandatory = true)] public required AzTenantType AzureTenantType { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        CheckTenantPartnerStatusResponseBody outputObject = new(AzureTenantType, PartnerPrincipalId, TenantPrincipalId);
        WriteObject(outputObject);
    }
}
