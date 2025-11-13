using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "Schedules")]
public class RemoveSchedules : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScheduleId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/schedules/{ScheduleId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
