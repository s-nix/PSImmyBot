using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ScriptReference")]
public class GetScriptReference : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/local/{ScriptId}/references?";

        List<ScriptReference> response = ImmyBotApiService.Get<List<ScriptReference>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
