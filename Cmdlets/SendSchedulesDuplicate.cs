using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SchedulesDuplicate")]
public class SendSchedulesDuplicate : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScheduleId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/schedules/{ScheduleId}/duplicate?";

        GetScheduleResponse response = ImmyBotApiService.Post<GetScheduleResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
