using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "ScriptsLocal")]
public class RemoveScriptsLocal : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/local/{ScriptId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
