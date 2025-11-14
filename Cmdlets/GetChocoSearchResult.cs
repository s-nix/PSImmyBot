using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ChocoSearchResult")]
public class GetChocoSearchResult : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? SearchTerm { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/chocolatey/search?";
        endpoint += Globals.ConvertToQueryParameters(SearchTerm, "searchTerm");

        List<ChocoSearchResult> response = ImmyBotApiService.Get<List<ChocoSearchResult>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
