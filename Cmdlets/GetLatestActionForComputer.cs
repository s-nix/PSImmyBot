using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LatestActionForComputer")]
public class GetLatestActionForComputer : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-actions/latest-for-computer/{ComputerId}?";

        List<LatestActionForComputer> response = ImmyBotApiService.Get<List<LatestActionForComputer>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
