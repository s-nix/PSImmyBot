using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceTaskSearchResult")]
public class GetMaintenanceTaskSearchResult : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? Filters { get; set; }

     [Parameter(Mandatory = false)]
    public string? Sorts { get; set; }

     [Parameter(Mandatory = false)]
    public int? Page { get; set; }

     [Parameter(Mandatory = false)]
    public int? PageSize { get; set; }

     [Parameter(Mandatory = false)]
    public bool? GlobalOnly { get; set; }

     [Parameter(Mandatory = false)]
    public bool? ConfigurationTaskOnly { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/search?";
        endpoint += Globals.ConvertToQueryParameters(Filters);
         endpoint += Globals.ConvertToQueryParameters(Sorts);
         endpoint += Globals.ConvertToQueryParameters(Page);
         endpoint += Globals.ConvertToQueryParameters(PageSize);
         endpoint += Globals.ConvertToQueryParameters(GlobalOnly);
         endpoint += Globals.ConvertToQueryParameters(ConfigurationTaskOnly);

        List<MaintenanceTaskSearchResult> response = ImmyBotApiService.Get<List<MaintenanceTaskSearchResult>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
