using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "Licenses")]
public class RemoveLicenses : Cmdlet {
    [Parameter(Mandatory = true)]
    public int LicenseId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/licenses/{LicenseId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
