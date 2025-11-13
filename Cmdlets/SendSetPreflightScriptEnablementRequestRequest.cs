using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SetPreflightScriptEnablementRequestRequest")]
public class SendSetPreflightScriptEnablementRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required SetPreflightScriptEnablementRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/set-preflight-script-enablement?";

        OpResult response = ImmyBotApiService.Post<SetPreflightScriptEnablementRequest, OpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
