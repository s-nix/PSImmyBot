using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ValidateParamBlockParametersFromScriptRequestRequest")]
public class SendValidateParamBlockParametersFromScriptRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ValidateParamBlockParametersFromScriptRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/validate-param-block-parameters?";

        DynamicFormBindResult response = ImmyBotApiService.Post<ValidateParamBlockParametersFromScriptRequest, DynamicFormBindResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
