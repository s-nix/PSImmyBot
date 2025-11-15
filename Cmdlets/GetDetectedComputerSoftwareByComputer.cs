using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "DetectedComputerSoftwareByComputer")]
public class GetDetectedComputerSoftwareByComputer : Cmdlet {
    [Parameter(Mandatory = true)]
    public int? ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/detected-computer-software?";

        List<DetectedComputerSoftwareResponse> response = ImmyBotApiService.Get<List<DetectedComputerSoftwareResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
