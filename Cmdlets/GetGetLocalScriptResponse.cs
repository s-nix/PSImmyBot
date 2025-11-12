using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetLocalScriptResponse")]
public class GetGetLocalScriptResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/local/{ScriptId}?";

        GetLocalScriptResponse response = ImmyBotApiService.Get<GetLocalScriptResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
