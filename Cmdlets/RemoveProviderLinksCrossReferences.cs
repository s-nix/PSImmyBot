using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "ProviderLinksCrossReferences")]
public class RemoveProviderLinksCrossReferences : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

     [Parameter(Mandatory = true)]
    public int ExternalLinkId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/cross-references/{ExternalLinkId}/delete?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
