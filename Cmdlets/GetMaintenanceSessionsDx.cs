using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceSessionsDx")]
public class GetMaintenanceSessionsDx : Cmdlet
{
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = false)]
    public int? ComputerId { get; set; }

    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }

    [Parameter(Mandatory = false)]
    public int? PersonId { get; set; }

    [Parameter(Mandatory = false)]
    public SessionType? SessionType { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/maintenance-sessions/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
        endpoint += Globals.ConvertToQueryParameters(ComputerId, "computerId");
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");
        endpoint += Globals.ConvertToQueryParameters(PersonId, "personId");
        endpoint += Globals.ConvertToQueryParameters(SessionType, "sessionType");

        LoadResult response = ImmyBotApiService.Get<LoadResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
