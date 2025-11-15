using System.Collections.Generic;
using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SchedulesBulkRunNow")]
public class SendSchedulesBulkRunNow : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required BulkScheduleRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/schedules/bulk-run-now?";
        List<BulkScheduleOperationResult> response = ImmyBotApiService
            .Post<BulkScheduleRequest, List<BulkScheduleOperationResult>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
