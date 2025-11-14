using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkScheduleRequest")]
public class NewBulkScheduleRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? ScheduleIds { get; set; }

    protected override void ProcessRecord() {
        BulkScheduleRequest outputObject = new(ScheduleIds);
        WriteObject(outputObject);
    }
}
