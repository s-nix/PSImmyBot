using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ChocoPackageVersion")]
public class GetChocoPackageVersion : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? PackageId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/chocolatey/find-packages-by-id?";
        endpoint += Globals.ConvertToQueryParameters(PackageId, "packageId");

        List<ChocoPackageVersion> response = ImmyBotApiService.Get<List<ChocoPackageVersion>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
