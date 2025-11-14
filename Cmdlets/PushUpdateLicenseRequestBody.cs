using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateLicenseRequestBody")]
public class PushUpdateLicenseRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int LicenseId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateLicenseRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/licenses/{LicenseId}?";

        GetLicenseResponse response = ImmyBotApiService.Put<UpdateLicenseRequestBody, GetLicenseResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
