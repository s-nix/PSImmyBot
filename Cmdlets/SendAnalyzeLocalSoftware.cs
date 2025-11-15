using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "AnalyzeLocalSoftware")]
public class SendAnalyzeLocalSoftware : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required AnalyzePackageParams PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/software/local/analyze?";
        AnalyzeLocalSoftwarePackageResponse response = ImmyBotApiService
            .Post<AnalyzePackageParams, AnalyzeLocalSoftwarePackageResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
