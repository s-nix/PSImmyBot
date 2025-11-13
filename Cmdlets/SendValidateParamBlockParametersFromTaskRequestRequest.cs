using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ValidateParamBlockParametersFromTaskRequestRequest")]
public class SendValidateParamBlockParametersFromTaskRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ValidateParamBlockParametersFromTaskRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/maintenance-tasks/validate-param-block-parameters?";

        DynamicFormBindResultWithConvertedParameters response = ImmyBotApiService.Post<ValidateParamBlockParametersFromTaskRequest, DynamicFormBindResultWithConvertedParameters>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
