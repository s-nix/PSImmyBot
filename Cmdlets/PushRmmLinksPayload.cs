using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "RmmLinksPayload")]
public class PushRmmLinksPayload : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateProviderLinkRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/rmm-links/{Id}?";

        GetProviderLinkResponse response = ImmyBotApiService.Put<UpdateProviderLinkRequestBody, GetProviderLinkResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
