using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateDynamicIntegrationTypePayload")]
public class SendUpdateDynamicIntegrationTypePayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateDynamicIntegrationTypePayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dynamic-provider-types/local/{Id}?";

        DynamicIntegrationTypeResponse response = ImmyBotApiService.Post<UpdateDynamicIntegrationTypePayload, DynamicIntegrationTypeResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
