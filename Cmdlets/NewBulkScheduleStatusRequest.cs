using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkScheduleStatusRequest")]
public class NewBulkScheduleStatusRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Disabled { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? ScheduleIds { get; set; }

    protected override void ProcessRecord() {
        BulkScheduleStatusRequest outputObject = new(Disabled, ScheduleIds);
        WriteObject(outputObject);
    }
}
