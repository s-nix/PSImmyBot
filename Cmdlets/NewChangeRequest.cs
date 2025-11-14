using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChangeRequest")]
public class NewChangeRequest : Cmdlet {
    [Parameter(Mandatory = false)] public int? AcknowledgedByUserId { get; set; }
    [Parameter(Mandatory = false)] public string? AcknowledgedByUserName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequestComment>? Comments { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required object NewValuesJson { get; set; }
    [Parameter(Mandatory = true)] public required ChangeRequestObjectType ObjectType { get; set; }
    [Parameter(Mandatory = true)] public required Script Script { get; set; }
    [Parameter(Mandatory = false)] public int? ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required ChangeRequestState State { get; set; }
    [Parameter(Mandatory = true)] public required TargetAssignment TargetAssignment { get; set; }
    [Parameter(Mandatory = false)] public int? TargetAssignmentId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        ChangeRequest outputObject = new(AcknowledgedByUserId, AcknowledgedByUserName, Comments, CreatedBy, CreatedByUser, CreatedDate, Id, NewValuesJson, ObjectType, Script, ScriptId, State, TargetAssignment, TargetAssignmentId, UpdatedBy, UpdatedByUser, UpdatedDate);
        WriteObject(outputObject);
    }
}
