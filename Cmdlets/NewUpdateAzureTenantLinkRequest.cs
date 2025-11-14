using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateAzureTenantLinkRequest")]
public class NewUpdateAzureTenantLinkRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? LimitToDomains { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required bool RemoveCustomersSyncedUsers { get; set; }
    [Parameter(Mandatory = true)] public required bool RemoveSyncedUsers { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = true)] public required bool UnlinkCustomers { get; set; }

    protected override void ProcessRecord() {
        UpdateAzureTenantLinkRequest outputObject = new(LimitToDomains, PartnerPrincipalId, PrincipalId, RemoveCustomersSyncedUsers, RemoveSyncedUsers, TenantId, UnlinkCustomers);
        WriteObject(outputObject);
    }
}
