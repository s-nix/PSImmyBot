using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ProviderLinks")]
public class GetProviderLinks : Cmdlet
{
    [Parameter(Mandatory = false)]
    public bool? IncludeClients { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeUnlinkedClients { get; set; }

    [Parameter(Mandatory = false)]
    public bool? ThrowIfAgentInstallerVersionNotSet { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/provider-links?";
        endpoint += Globals.ConvertToQueryParameters(IncludeClients, "includeClients");
        endpoint += Globals.ConvertToQueryParameters(IncludeUnlinkedClients, "includeUnlinkedClients");
        endpoint += Globals.ConvertToQueryParameters(ThrowIfAgentInstallerVersionNotSet, "throwIfAgentInstallerVersionNotSet");

        List<GetProviderLinkResponse> response = ImmyBotApiService.Get<List<GetProviderLinkResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
