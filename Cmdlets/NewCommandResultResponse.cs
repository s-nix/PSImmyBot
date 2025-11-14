using System.Management.Automation;
using PSImmyBot.Models;
using CommandTypes = PSImmyBot.Models.CommandTypes;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CommandResultResponse")]
public class NewCommandResultResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required CommandTypes CommandType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        CommandResultResponse outputObject = new(CommandType, Name);
        WriteObject(outputObject);
    }
}
