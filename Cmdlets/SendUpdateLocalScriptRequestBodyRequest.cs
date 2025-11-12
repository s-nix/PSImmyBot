using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateLocalScriptRequestBodyRequest")]
public class SendUpdateLocalScriptRequestBodyRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }

     [Parameter(Mandatory = false)]
    public bool? IgnoreSyntaxErrors { get; set; }


    [Parameter(Mandatory = true)] public required UpdateLocalScriptRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/local/{ScriptId}?";
        endpoint += Globals.ConvertToQueryParameters(IgnoreSyntaxErrors, "ignoreSyntaxErrors");

        GetLocalScriptResponse response = ImmyBotApiService.Post<UpdateLocalScriptRequestBody, GetLocalScriptResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
