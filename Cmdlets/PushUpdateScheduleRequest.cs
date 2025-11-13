using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateScheduleRequest")]
public class PushUpdateScheduleRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ScheduleId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateScheduleRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/schedules/{ScheduleId}?";

        GetScheduleResponse response = ImmyBotApiService.Put<UpdateScheduleRequest, GetScheduleResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
