using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "BulkScheduleStatusRequest")]
public class UpdateBulkScheduleStatusRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required BulkScheduleStatusRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/schedules/bulk-update-status?";

        List<BulkScheduleOperationResult> response = ImmyBotApiService.Patch<BulkScheduleStatusRequest, List<BulkScheduleOperationResult>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
