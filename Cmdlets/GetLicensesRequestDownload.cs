using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LicensesRequestDownload")]
public class GetLicensesRequestDownload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int LicenseId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/licenses/{LicenseId}/request-download?";

        string response = ImmyBotApiService.Get<string>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
