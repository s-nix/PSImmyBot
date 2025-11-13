using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChangeRequestComment")]
public class NewChangeRequestComment : Cmdlet {
    [Parameter(Mandatory = true)] public required ChangeRequest ChangeRequest { get; set; }
    [Parameter(Mandatory = true)] public required int ChangeRequestId { get; set; }
    [Parameter(Mandatory = false)] public string? Comment { get; set; }
    [Parameter(Mandatory = false)] public string? CommentedByUsername { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        ChangeRequestComment outputObject = new(ChangeRequest, ChangeRequestId, Comment, CommentedByUsername, CreatedBy, CreatedByUser, CreatedDate, Id, UpdatedBy, UpdatedByUser, UpdatedDate);
        WriteObject(outputObject);
    }
}
