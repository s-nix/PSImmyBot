using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenant")]
public class NewAzureTenant : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<AzureTenantLink>? AzureTenantLinks { get; set; }
    [Parameter(Mandatory = true)] public required AzTenantType AzureTenantType { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantConsentDetails ConsentDetails { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantInfo InfoSyncedFromAzure { get; set; }
    [Parameter(Mandatory = true)] public required AzureSyncResult LastGetTenantInfoSyncResult { get; set; }
    [Parameter(Mandatory = true)] public required AzureSyncResult LastGetUsersSyncResult { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenant ParentPartner { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }

    protected override void ProcessRecord() {
        AzureTenant outputObject = new(AzureTenantLinks, AzureTenantType, ConsentDetails, InfoSyncedFromAzure, LastGetTenantInfoSyncResult, LastGetUsersSyncResult, ParentPartner, PartnerPrincipalId, PrincipalId);
        WriteObject(outputObject);
    }
}
