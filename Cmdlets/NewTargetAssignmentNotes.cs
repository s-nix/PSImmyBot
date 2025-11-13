using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TargetAssignmentNotes")]
public class NewTargetAssignmentNotes : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required TargetAssignment TargetAssignment { get; set; }
    [Parameter(Mandatory = true)] public required int TargetAssignmentId { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedByName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        TargetAssignmentNotes outputObject = new(CreatedDate, Id, Notes, TargetAssignment, TargetAssignmentId, UpdatedByName, UpdatedDate);
        WriteObject(outputObject);
    }
}
