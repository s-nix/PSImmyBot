using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "TestIntegrationBindConfigurationFormRequestRequest")]
public class SendTestIntegrationBindConfigurationFormRequestRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string TerminalId { get; set; }


    [Parameter(Mandatory = true)] public required TestIntegrationBindConfigurationFormRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dynamic-provider-types/test-environment/{TerminalId}/bind-configuration-form?";

        DynamicFormBindResultOpResult response = ImmyBotApiService.Post<TestIntegrationBindConfigurationFormRequest, DynamicFormBindResultOpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
