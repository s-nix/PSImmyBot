using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BatchUpdateAssignmentRequest")]
public class NewBatchUpdateAssignmentRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? TargetAssignmentIds { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UpdateTargetVisibilityPayload>? UpdateArray { get; set; }

    protected override void ProcessRecord() {
        BatchUpdateAssignmentRequest outputObject = new(TargetAssignmentIds, UpdateArray);
        WriteObject(outputObject);
    }
}
