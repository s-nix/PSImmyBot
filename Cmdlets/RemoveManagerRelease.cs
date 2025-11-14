using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "ManagerRelease")]
public class RemoveManagerRelease : Cmdlet {
    [Parameter(Mandatory = true)]
    public required SemanticVersion Tag { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/manager/release/{Tag}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
