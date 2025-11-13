using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AddChangeRequestCommentBody")]
public class NewAddChangeRequestCommentBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? Comment { get; set; }

    protected override void ProcessRecord() {
        AddChangeRequestCommentBody outputObject = new(Comment);
        WriteObject(outputObject);
    }
}
