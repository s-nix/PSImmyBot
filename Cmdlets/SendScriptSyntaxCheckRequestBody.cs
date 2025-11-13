using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ScriptSyntaxCheckRequestBody")]
public class SendScriptSyntaxCheckRequestBody : Cmdlet {

    [Parameter(Mandatory = true)] public required ScriptSyntaxCheckRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/syntax-check?";

        SyntaxCheckerResult response = ImmyBotApiService.Post<ScriptSyntaxCheckRequestBody, SyntaxCheckerResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
