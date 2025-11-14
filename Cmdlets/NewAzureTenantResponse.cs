using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantResponse")]
public class NewAzureTenantResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required AzTenantType AzureTenantType { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantConsentDetails ConsentDetails { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantInfo InfoSyncedFromAzure { get; set; }
    [Parameter(Mandatory = true)] public required AzureSyncResult LastGetTenantInfoSyncResult { get; set; }
    [Parameter(Mandatory = true)] public required AzureSyncResult LastGetUsersSyncResult { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }

    protected override void ProcessRecord() {
        AzureTenantResponse outputObject = new(AzureTenantType, ConsentDetails, InfoSyncedFromAzure, LastGetTenantInfoSyncResult, LastGetUsersSyncResult, PartnerPrincipalId, PrincipalId);
        WriteObject(outputObject);
    }
}
