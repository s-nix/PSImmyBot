using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateBrandingRequestBody")]
public class PushUpdateBrandingRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateBrandingRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/brandings/{Id}?";

        GetBrandingResponse response = ImmyBotApiService.Put<UpdateBrandingRequestBody, GetBrandingResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
