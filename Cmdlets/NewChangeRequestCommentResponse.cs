using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChangeRequestCommentResponse")]
public class NewChangeRequestCommentResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int ChangeRequestId { get; set; }
    [Parameter(Mandatory = false)] public string? Comment { get; set; }
    [Parameter(Mandatory = false)] public string? CommentedByUsername { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }

    protected override void ProcessRecord() {
        ChangeRequestCommentResponse outputObject = new(ChangeRequestId, Comment, CommentedByUsername, CreatedDateUtc, Id);
        WriteObject(outputObject);
    }
}
