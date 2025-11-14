using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "DynamicIntegrationType")]
public class GetDynamicIntegrationType : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }
    
    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dynamic-provider-types/local/{Id}?";

        DynamicIntegrationTypeResponse response = ImmyBotApiService.Get<DynamicIntegrationTypeResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
