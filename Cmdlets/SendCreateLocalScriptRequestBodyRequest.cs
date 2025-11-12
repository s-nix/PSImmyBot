using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLocalScriptRequestBodyRequest")]
public class SendCreateLocalScriptRequestBodyRequest : Cmdlet {
    [Parameter(Mandatory = false)]
    public bool? IgnoreSyntaxErrors { get; set; }


    [Parameter(Mandatory = true)] public required CreateLocalScriptRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/local?";
        endpoint += Globals.ConvertToQueryParameters(IgnoreSyntaxErrors, "ignoreSyntaxErrors");

        GetLocalScriptResponse response = ImmyBotApiService.Post<CreateLocalScriptRequestBody, GetLocalScriptResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
