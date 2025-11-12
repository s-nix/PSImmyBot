using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetScriptNameResponse")]
public class GetGetScriptNameResponse : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? SearchFilter { get; set; }

     [Parameter(Mandatory = false)]
    public ScriptCategory? ScriptCategory { get; set; }

     [Parameter(Mandatory = false)]
    public string? SearchType { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/local/names?";
        endpoint += Globals.ConvertToQueryParameters(SearchFilter);
         endpoint += Globals.ConvertToQueryParameters(ScriptCategory);
         endpoint += Globals.ConvertToQueryParameters(SearchType);

        List<GetScriptNameResponse> response = ImmyBotApiService.Get<List<GetScriptNameResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
