using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChangeRequestParameterDiff")]
public class NewChangeRequestParameterDiff : Cmdlet {
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required DeploymentParameterValue NewValue { get; set; }
    [Parameter(Mandatory = true)] public required DeploymentParameterValue OldValue { get; set; }

    protected override void ProcessRecord() {
        ChangeRequestParameterDiff outputObject = new(Name, NewValue, OldValue);
        WriteObject(outputObject);
    }
}
