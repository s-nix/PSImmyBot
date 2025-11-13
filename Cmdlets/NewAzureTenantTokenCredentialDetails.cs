using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantTokenCredentialDetails")]
public class NewAzureTenantTokenCredentialDetails : Cmdlet {
    [Parameter(Mandatory = true)] public required AccessTokenSource GotAccessTokenFrom { get; set; }
    [Parameter(Mandatory = true)] public required bool OnlyUsePartnerCenterRefresh { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? ResolvedClientId { get; set; }
    [Parameter(Mandatory = true)] public required AzurePermissionLevel2 TenantAzurePermissionLevel { get; set; }
    [Parameter(Mandatory = false)] public string? TenantPreferredAzureClientId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        AzureTenantTokenCredentialDetails outputObject = new(GotAccessTokenFrom, OnlyUsePartnerCenterRefresh, PartnerPrincipalId, ResolvedClientId, TenantAzurePermissionLevel, TenantPreferredAzureClientId, TenantPrincipalId);
        WriteObject(outputObject);
    }
}
