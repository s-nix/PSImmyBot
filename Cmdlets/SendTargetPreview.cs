using System.Collections.Generic;
using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "TargetPreview")]
public class SendTargetPreview : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required CalculateTargetsRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/target-assignments/target-preview?";
        List<CalculateTargetedComputerResponse> response = ImmyBotApiService
            .Post<CalculateTargetsRequest, List<CalculateTargetedComputerResponse>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
