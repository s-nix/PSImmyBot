using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "VerifyProviderLinkWithExternalReference")]
public class SendVerifyProviderLinkWithExternalReference : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required CreateProviderLinkWithExternalProviderReferenceRequestBody PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/provider-links/verify-with-external-provider-reference?";
        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }
}
