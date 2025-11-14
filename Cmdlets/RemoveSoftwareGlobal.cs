using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "SoftwareGlobal")]
public class RemoveSoftwareGlobal : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
