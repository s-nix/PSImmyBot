using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "AnalyzePackageParamsRequest")]
public class SendAnalyzePackageParamsRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required AnalyzePackageParams PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/software/global/analyze?";

        AnalyzeGlobalSoftwarePackageResponse response = ImmyBotApiService.Post<AnalyzePackageParams, AnalyzeGlobalSoftwarePackageResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
