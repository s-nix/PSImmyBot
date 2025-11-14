using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateProviderLinkRequestBody")]
public class PushUpdateProviderLinkRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

     [Parameter(Mandatory = false)]
    public bool? ThrowIfAgentInstallerVersionNotSet { get; set; }


    [Parameter(Mandatory = true)] public required UpdateProviderLinkRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}?";
        endpoint += Globals.ConvertToQueryParameters(ThrowIfAgentInstallerVersionNotSet, "throwIfAgentInstallerVersionNotSet");

        GetProviderLinkResponse response = ImmyBotApiService.Put<UpdateProviderLinkRequestBody, GetProviderLinkResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
