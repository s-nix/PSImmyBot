using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RoviderLinksClientsLinkExactMatchClientsRequest")]
public class SendRoviderLinksClientsLinkExactMatchClientsRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/clients/link-exact-match-clients?";

        List<ProviderClientLinkToTenantByExactNameResponse> response = ImmyBotApiService.Post<List<ProviderClientLinkToTenantByExactNameResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
