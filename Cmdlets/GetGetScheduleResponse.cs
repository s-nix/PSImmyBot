using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetScheduleResponse")]
public class GetGetScheduleResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScheduleId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/schedules/{ScheduleId}?";

        GetScheduleResponse response = ImmyBotApiService.Get<GetScheduleResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
