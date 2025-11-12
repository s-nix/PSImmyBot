using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DuplicateScriptRequestBodyRequest")]
public class SendDuplicateScriptRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required DuplicateScriptRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/duplicate?";

        GetLocalScriptResponse response = ImmyBotApiService.Post<DuplicateScriptRequestBody, GetLocalScriptResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
