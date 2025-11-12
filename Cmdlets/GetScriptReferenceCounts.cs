using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ScriptReferenceCounts")]
public class GetScriptReferenceCounts : Cmdlet {
    [Parameter(Mandatory = false)]
    public DatabaseType? ScriptType { get; set; }

    [Parameter(Mandatory = false)]
    public int? Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/references/count?";
        endpoint += Globals.ConvertToQueryParameters(ScriptType, "scriptType");
        endpoint += Globals.ConvertToQueryParameters(Id, "id");

        ScriptReferenceCounts response = ImmyBotApiService.Get<ScriptReferenceCounts>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
