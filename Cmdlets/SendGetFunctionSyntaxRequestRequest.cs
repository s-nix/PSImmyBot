using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetFunctionSyntaxRequestRequest")]
public class SendGetFunctionSyntaxRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required GetFunctionSyntaxRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/functions/syntax?";

        string response = ImmyBotApiService.Post<GetFunctionSyntaxRequest, string>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
