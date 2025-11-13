using System.Management.Automation;
using PSImmyBot.Models;
using CommandTypes = PSImmyBot.Models.CommandTypes;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetCommandResult")]
public class NewGetCommandResult : Cmdlet {
    [Parameter(Mandatory = true)] public required CommandTypes CommandType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        GetCommandResult outputObject = new(CommandType, Name);
        WriteObject(outputObject);
    }
}
