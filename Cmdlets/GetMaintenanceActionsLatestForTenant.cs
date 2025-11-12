using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceActionsLatestForTenant")]
public class GetMaintenanceActionsLatestForTenant : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

     [Parameter(Mandatory = true)]
    public int TenantId { get; set; }

     [Parameter(Mandatory = false)]
    public string? CreatedDateUtc { get; set; }

     [Parameter(Mandatory = false)]
    public SessionType? SessionType { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-actions/latest-for-tenant/{TenantId}?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
         endpoint += Globals.ConvertToQueryParameters(CreatedDateUtc);
         endpoint += Globals.ConvertToQueryParameters(SessionType);

        object response = ImmyBotApiService.Get<object>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
