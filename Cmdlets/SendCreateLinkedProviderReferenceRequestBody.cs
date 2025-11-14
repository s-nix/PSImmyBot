using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLinkedProviderReferenceRequestBody")]
public class SendCreateLinkedProviderReferenceRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required CreateLinkedProviderReferenceRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/cross-references/create?";

        LinkedExternalLink response = ImmyBotApiService.Post<CreateLinkedProviderReferenceRequestBody, LinkedExternalLink>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
