using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateGlobalScriptRequestBodyRequest")]
public class SendUpdateGlobalScriptRequestBodyRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScriptId { get; set; }

     [Parameter(Mandatory = false)]
    public bool? IgnoreSyntaxErrors { get; set; }


    [Parameter(Mandatory = true)] public required UpdateGlobalScriptRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/global/{ScriptId}?";
        endpoint += Globals.ConvertToQueryParameters(IgnoreSyntaxErrors, "ignoreSyntaxErrors");

        GetGlobalScriptResponse response = ImmyBotApiService.Post<UpdateGlobalScriptRequestBody, GetGlobalScriptResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
