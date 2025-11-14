using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SyntaxCheckerResult")]
public class NewSyntaxCheckerResult : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? Errors { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSyntaxValid { get; set; }

    protected override void ProcessRecord() {
        SyntaxCheckerResult outputObject = new(Errors, IsSyntaxValid);
        WriteObject(outputObject);
    }
}
