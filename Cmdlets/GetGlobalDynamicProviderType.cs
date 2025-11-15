using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalDynamicProviderType")]
public class GetGlobalDynamicProviderType : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/dynamic-provider-types/global/{Id}?";

        DynamicIntegrationTypeResponse response = ImmyBotApiService.Get<DynamicIntegrationTypeResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
