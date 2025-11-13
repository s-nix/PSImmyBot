using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantDetailsSyncResult")]
public class NewAzureTenantDetailsSyncResult : Cmdlet {
    [Parameter(Mandatory = true)] public required AzureError FailedReason { get; set; }
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantInfo TenantInformationSynced { get; set; }
    [Parameter(Mandatory = true)] public required bool WasSuccessful { get; set; }

    protected override void ProcessRecord() {
        AzureTenantDetailsSyncResult outputObject = new(FailedReason, PrincipalId, TenantInformationSynced, WasSuccessful);
        WriteObject(outputObject);
    }
}
