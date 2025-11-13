using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLicenseRequestBodyRequest")]
public class SendCreateLicenseRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateLicenseRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/licenses?";

        GetLicenseResponse response = ImmyBotApiService.Post<CreateLicenseRequestBody, GetLicenseResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
