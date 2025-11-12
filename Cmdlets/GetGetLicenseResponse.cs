using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetLicenseResponse")]
public class GetGetLicenseResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int LicenseId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/licenses/{LicenseId}?";

        GetLicenseResponse response = ImmyBotApiService.Get<GetLicenseResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
