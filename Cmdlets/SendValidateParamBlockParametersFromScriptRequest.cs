using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ValidateParamBlockParametersFromScriptRequest")]
public class SendValidateParamBlockParametersFromScriptRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ValidateParamBlockParametersFromScriptRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/validate-param-block-parameters?";

        DynamicFormBindResult response = ImmyBotApiService.Post<ValidateParamBlockParametersFromScriptRequest, DynamicFormBindResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
