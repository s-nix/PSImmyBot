using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChangeRequestResponse")]
public class NewChangeRequestResponse : Cmdlet {
    [Parameter(Mandatory = false)] public int? AcknowledgedByUserId { get; set; }
    [Parameter(Mandatory = false)] public string? AcknowledgedByUserName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequestCommentResponse>? Comments { get; set; }
    [Parameter(Mandatory = false)] public string? CreatedByUserName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required object NewValuesJson { get; set; }
    [Parameter(Mandatory = true)] public required ChangeRequestObjectType ObjectType { get; set; }
    [Parameter(Mandatory = false)] public int? ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required ChangeRequestState State { get; set; }
    [Parameter(Mandatory = false)] public int? TargetAssignmentId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        ChangeRequestResponse outputObject = new(AcknowledgedByUserId, AcknowledgedByUserName, Comments, CreatedByUserName, CreatedDateUtc, Id, NewValuesJson, ObjectType, ScriptId, State, TargetAssignmentId, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
