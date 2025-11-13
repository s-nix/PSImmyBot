using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DoesScriptHaveParamBlockRequestRequest")]
public class SendDoesScriptHaveParamBlockRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required DoesScriptHaveParamBlockRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/does-script-have-param-block?";

        bool response = ImmyBotApiService.Post<DoesScriptHaveParamBlockRequest, bool>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
