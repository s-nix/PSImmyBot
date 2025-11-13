using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ScriptsLocalMigrateLocalToGlobal")]
public class SendScriptsLocalMigrateLocalToGlobal : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/local/{ScriptId}/migrate-local-to-global?";

        int response = ImmyBotApiService.Post<int>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
