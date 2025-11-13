using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CommandResult")]
public class NewCommandResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }

    protected override void ProcessRecord() {
        CommandResult outputObject = new(Message, Success);
        WriteObject(outputObject);
    }
}
