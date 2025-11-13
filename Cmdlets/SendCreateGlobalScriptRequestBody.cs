using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateGlobalScriptRequestBody")]
public class SendCreateGlobalScriptRequestBody : Cmdlet {
    [Parameter(Mandatory = false)]
    public bool? IgnoreSyntaxErrors { get; set; }


    [Parameter(Mandatory = true)] public required CreateGlobalScriptRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/global?";
        endpoint += Globals.ConvertToQueryParameters(IgnoreSyntaxErrors, "ignoreSyntaxErrors");

        GetGlobalScriptResponse response = ImmyBotApiService.Post<CreateGlobalScriptRequestBody, GetGlobalScriptResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
