using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "LinkClientToNewTenantRequestBodyRequest")]
public class SendLinkClientToNewTenantRequestBodyRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required LinkClientToNewTenantRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/clients/link-to-new-tenant?";

        LinkClientToNewTenantResponseBody response = ImmyBotApiService.Post<LinkClientToNewTenantRequestBody, LinkClientToNewTenantResponseBody>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
