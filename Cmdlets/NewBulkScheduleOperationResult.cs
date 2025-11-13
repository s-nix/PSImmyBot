using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkScheduleOperationResult")]
public class NewBulkScheduleOperationResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? ErrorMessage { get; set; }
    [Parameter(Mandatory = true)] public required int ScheduleId { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }

    protected override void ProcessRecord() {
        BulkScheduleOperationResult outputObject = new(ErrorMessage, ScheduleId, Success);
        WriteObject(outputObject);
    }
}
