using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SchedulesRunNow")]
public class SendSchedulesRunNow : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScheduleId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/schedules/{ScheduleId}/run-now?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
