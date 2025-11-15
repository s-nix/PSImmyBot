using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ProviderLinkPluginResource")]
public class GetProviderLinkPluginResource : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ProviderLinkId { get; set; }

    [Parameter(Mandatory = true)]
    public required string CatchAll { get; set; }


    protected override void ProcessRecord()
    {
        string catchAllPath = CatchAll.TrimStart('/');
        string endpoint = $"/plugins/api/v1/{ProviderLinkId}/{catchAllPath}";

        object response = ImmyBotApiService.Get<object>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
