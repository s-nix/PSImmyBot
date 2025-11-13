using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateDynamicIntegrationTypePayloadRequest")]
public class SendCreateDynamicIntegrationTypePayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateDynamicIntegrationTypePayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/dynamic-provider-types/local;?";

        DynamicIntegrationTypeResponse response = ImmyBotApiService.Post<CreateDynamicIntegrationTypePayload, DynamicIntegrationTypeResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
