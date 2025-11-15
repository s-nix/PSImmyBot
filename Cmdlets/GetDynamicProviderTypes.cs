using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "DynamicProviderTypes")]
public class GetDynamicProviderTypes : Cmdlet
{
    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/dynamic-provider-types?";

        List<DynamicIntegrationTypeResponse> response = ImmyBotApiService.Get<List<DynamicIntegrationTypeResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
