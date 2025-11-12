using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "SchedulesRunningScheduleIds")]
public class GetSchedulesRunningScheduleIds : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/schedules/running-schedule-ids?";

        object response = ImmyBotApiService.Get<object>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
