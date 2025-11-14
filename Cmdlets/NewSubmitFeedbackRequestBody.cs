using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SubmitFeedbackRequestBody")]
public class NewSubmitFeedbackRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? Details { get; set; }
    [Parameter(Mandatory = false)] public string? Rating { get; set; }

    protected override void ProcessRecord() {
        SubmitFeedbackRequestBody outputObject = new(Details, Rating);
        WriteObject(outputObject);
    }
}
