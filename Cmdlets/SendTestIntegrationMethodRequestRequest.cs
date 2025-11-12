using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "TestIntegrationMethodRequestRequest")]
public class SendTestIntegrationMethodRequestRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string TerminalId { get; set; }

     [Parameter(Mandatory = true)]
    public required string Method { get; set; }


    [Parameter(Mandatory = true)] public required TestIntegrationMethodRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dynamic-provider-types/test-environment/{TerminalId}/execute-method/{Method}?";

        ObjectOpResult response = ImmyBotApiService.Post<TestIntegrationMethodRequest, ObjectOpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
