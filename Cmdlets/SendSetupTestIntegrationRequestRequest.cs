using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SetupTestIntegrationRequestRequest")]
public class SendSetupTestIntegrationRequestRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string TerminalId { get; set; }


    [Parameter(Mandatory = true)] public required SetupTestIntegrationRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dynamic-provider-types/test-environment/{TerminalId}?";

        DynamicFormBindResultOpResult response = ImmyBotApiService.Post<SetupTestIntegrationRequest, DynamicFormBindResultOpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
