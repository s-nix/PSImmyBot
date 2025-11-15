using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalMaintenanceTasks")]
public class GetLocalMaintenanceTasks : Cmdlet
{
    [Parameter(Mandatory = false)]
    public string? Filters { get; set; }

    [Parameter(Mandatory = false)]
    public string? Sorts { get; set; }

    [Parameter(Mandatory = false)]
    public int? Page { get; set; }

    [Parameter(Mandatory = false)]
    public int? PageSize { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/maintenance-tasks/local?";
        endpoint += Globals.ConvertToQueryParameters(Filters, "filters");
        endpoint += Globals.ConvertToQueryParameters(Sorts, "sorts");
        endpoint += Globals.ConvertToQueryParameters(Page, "page");
        endpoint += Globals.ConvertToQueryParameters(PageSize, "pageSize");

        List<GetLocalMaintenanceTaskResponse> response = ImmyBotApiService.Get<List<GetLocalMaintenanceTaskResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
