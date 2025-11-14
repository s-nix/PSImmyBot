using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TimelineEvent")]
public class GetTimelineEvent : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }

    [Parameter(Mandatory = false)]
    public int? Skip { get; set; }

    [Parameter(Mandatory = false)]
    public int? Take { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/events?";
        endpoint += Globals.ConvertToQueryParameters(Skip, "skip");
        endpoint += Globals.ConvertToQueryParameters(Take, "take");

        List<TimelineEvent> response = ImmyBotApiService.Get<List<TimelineEvent>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
