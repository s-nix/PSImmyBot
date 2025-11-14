using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateScheduleRequest")]
public class SendCreateScheduleRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateScheduleRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/schedules?";

        GetScheduleResponse response = ImmyBotApiService.Post<CreateScheduleRequest, GetScheduleResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
