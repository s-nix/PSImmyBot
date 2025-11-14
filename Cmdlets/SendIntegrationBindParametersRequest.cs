using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "IntegrationBindParametersRequest")]
public class SendIntegrationBindParametersRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string ProviderType { get; set; }


    [Parameter(Mandatory = true)] public required IntegrationBindParametersRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-types/{ProviderType}/bind-parameters?";

        DynamicFormBindResult response = ImmyBotApiService.Post<IntegrationBindParametersRequest, DynamicFormBindResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
