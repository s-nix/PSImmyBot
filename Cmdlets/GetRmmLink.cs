using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "RmmLink")]
public class GetRmmLink : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeClients { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeProvidersLinkedFromThisProvider { get; set; }

    [Parameter(Mandatory = false)]
    public bool? ThrowIfAgentInstallerVersionNotSet { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/rmm-links/{Id}?";
        endpoint += Globals.ConvertToQueryParameters(IncludeClients, "includeClients");
        endpoint += Globals.ConvertToQueryParameters(IncludeProvidersLinkedFromThisProvider, "includeProvidersLinkedFromThisProvider");
        endpoint += Globals.ConvertToQueryParameters(ThrowIfAgentInstallerVersionNotSet, "throwIfAgentInstallerVersionNotSet");

        GetProviderLinkResponse response = ImmyBotApiService.Get<GetProviderLinkResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
