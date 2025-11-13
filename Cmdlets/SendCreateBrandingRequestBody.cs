using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateBrandingRequestBody")]
public class SendCreateBrandingRequestBody : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateBrandingRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/brandings?";

        GetBrandingResponse response = ImmyBotApiService.Post<CreateBrandingRequestBody, GetBrandingResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
