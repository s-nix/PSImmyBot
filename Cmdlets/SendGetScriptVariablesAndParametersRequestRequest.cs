using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetScriptVariablesAndParametersRequestRequest")]
public class SendGetScriptVariablesAndParametersRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required GetScriptVariablesAndParametersRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/default-variables?";

        GetScriptVariablesAndParametersResponse response = ImmyBotApiService.Post<GetScriptVariablesAndParametersRequest, GetScriptVariablesAndParametersResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
