using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantUserSyncResult")]
public class NewAzureTenantUserSyncResult : Cmdlet {
    [Parameter(Mandatory = true)] public required AzureError FailedReason { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, int>? ImmyTenantsSyncedUsers { get; set; }
    [Parameter(Mandatory = true)] public required int NumUsersSynced { get; set; }
    [Parameter(Mandatory = false)] public string? PrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required bool WasSuccessful { get; set; }

    protected override void ProcessRecord() {
        AzureTenantUserSyncResult outputObject = new(FailedReason, ImmyTenantsSyncedUsers, NumUsersSynced, PrincipalId, WasSuccessful);
        WriteObject(outputObject);
    }
}
