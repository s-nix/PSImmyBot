using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RoviderLinksCrossReferencesDisableClientLinkingRequest")]
public class SendRoviderLinksCrossReferencesDisableClientLinkingRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

     [Parameter(Mandatory = true)]
    public int ExternalLinkId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/cross-references/{ExternalLinkId}/disable-client-linking?";

        LinkedExternalLink response = ImmyBotApiService.Post<LinkedExternalLink>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
