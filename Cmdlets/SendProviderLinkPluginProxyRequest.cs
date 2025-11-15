using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ProviderLinkPluginProxyRequest")]
public class SendProviderLinkPluginProxyRequest : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ProviderLinkId { get; set; }

    [Parameter(Mandatory = true)]
    public required string CatchAll { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = $"/plugins/api/v1/{ProviderLinkId}/{CatchAll}?";
        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }
}
