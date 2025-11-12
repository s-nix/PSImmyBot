using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "SoftwareGlobalVersionsRequestDownload")]
public class GetSoftwareGlobalVersionsRequestDownload : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string SoftwareIdentifier { get; set; }

    [Parameter(Mandatory = true)]
    public required SemanticVersion SemanticVersion { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/software/global/{SoftwareIdentifier}/versions/{SemanticVersion}/request-download?";

        string response = ImmyBotApiService.Get<string>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
