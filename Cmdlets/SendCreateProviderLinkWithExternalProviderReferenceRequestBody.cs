using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateProviderLinkWithExternalProviderReferenceRequestBody")]
public class SendCreateProviderLinkWithExternalProviderReferenceRequestBody : Cmdlet {
    [Parameter(Mandatory = false)]
    public bool? ThrowIfAgentInstallerVersionNotSet { get; set; }


    [Parameter(Mandatory = true)] public required CreateProviderLinkWithExternalProviderReferenceRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/provider-links/create-with-external-provider-reference?";
        endpoint += Globals.ConvertToQueryParameters(ThrowIfAgentInstallerVersionNotSet, "throwIfAgentInstallerVersionNotSet");

        GetProviderLinkResponse response = ImmyBotApiService.Post<CreateProviderLinkWithExternalProviderReferenceRequestBody, GetProviderLinkResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
