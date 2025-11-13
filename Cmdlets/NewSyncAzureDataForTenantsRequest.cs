using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SyncAzureDataForTenantsRequest")]
public class NewSyncAzureDataForTenantsRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllPartnerTenants { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? TenantPrincipalIds { get; set; }

    protected override void ProcessRecord() {
        SyncAzureDataForTenantsRequest outputObject = new(AllPartnerTenants, TenantPrincipalIds);
        WriteObject(outputObject);
    }
}
