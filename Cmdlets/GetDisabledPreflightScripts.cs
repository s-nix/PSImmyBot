using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "DisabledPreflightScripts")]
public class GetDisabledPreflightScripts : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/disabled-preflight-scripts?";

        List<DisabledPreflightScriptResponse> response = ImmyBotApiService.Get<List<DisabledPreflightScriptResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
