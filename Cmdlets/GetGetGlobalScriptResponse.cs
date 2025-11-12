using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetGlobalScriptResponse")]
public class GetGetGlobalScriptResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/global/{ScriptId}?";

        GetGlobalScriptResponse response = ImmyBotApiService.Get<GetGlobalScriptResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
