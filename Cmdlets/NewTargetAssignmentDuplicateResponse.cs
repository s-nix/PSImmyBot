using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TargetAssignmentDuplicateResponse")]
public class NewTargetAssignmentDuplicateResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int Count { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? DuplicateIds { get; set; }

    protected override void ProcessRecord() {
        TargetAssignmentDuplicateResponse outputObject = new(Count, DuplicateIds);
        WriteObject(outputObject);
    }
}
