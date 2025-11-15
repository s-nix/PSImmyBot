using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateGlobalDynamicProviderType")]
public class SendUpdateGlobalDynamicProviderType : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

    [Parameter(Mandatory = true)]
    public required UpdateDynamicIntegrationTypePayload PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/dynamic-provider-types/global/{Id}?";
        DynamicIntegrationTypeResponse response = ImmyBotApiService
            .Post<UpdateDynamicIntegrationTypePayload, DynamicIntegrationTypeResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
