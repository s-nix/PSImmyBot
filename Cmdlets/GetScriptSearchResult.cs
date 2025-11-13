using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ScriptSearchResult")]
public class GetScriptSearchResult : Cmdlet {
    [Parameter(Mandatory = false)]
    public bool? GlobalOnly { get; set; }

    [Parameter(Mandatory = false)]
    public string? Filters { get; set; }

    [Parameter(Mandatory = false)]
    public string? Sorts { get; set; }

    [Parameter(Mandatory = false)]
    public int? Page { get; set; }

    [Parameter(Mandatory = false)]
    public int? PageSize { get; set; }

    [Parameter(Mandatory = false)]
    public bool? LocalOnly { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/search?";
        endpoint += Globals.ConvertToQueryParameters(GlobalOnly, "globalOnly");
        endpoint += Globals.ConvertToQueryParameters(Filters, "filters");
        endpoint += Globals.ConvertToQueryParameters(Sorts, "sorts");
        endpoint += Globals.ConvertToQueryParameters(Page, "page");
        endpoint += Globals.ConvertToQueryParameters(PageSize, "pageSize");
        endpoint += Globals.ConvertToQueryParameters(LocalOnly, "localOnly");

        List<ScriptSearchResult> response = ImmyBotApiService.Get<List<ScriptSearchResult>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
