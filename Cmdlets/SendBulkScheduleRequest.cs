using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BulkScheduleRequest")]
public class SendBulkScheduleRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required BulkScheduleRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/schedules/bulk-cancel?";

        List<BulkScheduleOperationResult> response = ImmyBotApiService.Post<BulkScheduleRequest, List<BulkScheduleOperationResult>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
