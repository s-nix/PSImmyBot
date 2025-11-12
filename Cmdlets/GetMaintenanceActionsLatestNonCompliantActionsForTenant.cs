using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceActionsLatestNonCompliantActionsForTenant")]
public class GetMaintenanceActionsLatestNonCompliantActionsForTenant : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TenantId { get; set; }

     [Parameter(Mandatory = false)]
    public string? DateUtc { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-actions/latest-non-compliant-actions-for-tenant/{TenantId}?";
        endpoint += Globals.ConvertToQueryParameters(DateUtc);

        object response = ImmyBotApiService.Get<object>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
