using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateRmmLink")]
public class SendCreateRmmLink : Cmdlet
{
    [Parameter(Mandatory = false)]
    public bool? ThrowIfAgentInstallerVersionNotSet { get; set; }

    [Parameter(Mandatory = true)]
    public required CreateProviderLinkRequestBody PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/rmm-links?";
        endpoint += Globals.ConvertToQueryParameters(ThrowIfAgentInstallerVersionNotSet, "throwIfAgentInstallerVersionNotSet");

        GetProviderLinkResponse response = ImmyBotApiService
            .Post<CreateProviderLinkRequestBody, GetProviderLinkResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
