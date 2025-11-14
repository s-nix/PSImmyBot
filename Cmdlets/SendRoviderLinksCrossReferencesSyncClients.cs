using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RoviderLinksCrossReferencesSyncClients")]
public class SendRoviderLinksCrossReferencesSyncClients : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

     [Parameter(Mandatory = true)]
    public int ExternalLinkId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/cross-references/{ExternalLinkId}/sync-clients?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
