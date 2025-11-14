using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantInfoResult")]
public class NewTenantInfoResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantInfoAzureErrorOneOf Result { get; set; }

    protected override void ProcessRecord() {
        TenantInfoResult outputObject = new(PrincipalId, Result);
        WriteObject(outputObject);
    }
}
