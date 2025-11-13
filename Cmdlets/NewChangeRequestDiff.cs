using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChangeRequestDiff")]
public class NewChangeRequestDiff : Cmdlet {
    [Parameter(Mandatory = false)] public string? NewDeploymentDescription { get; set; }
    [Parameter(Mandatory = false)] public string? OldDeploymentDescription { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequestParameterDiff>? ParameterDiffs { get; set; }

    protected override void ProcessRecord() {
        ChangeRequestDiff outputObject = new(NewDeploymentDescription, OldDeploymentDescription, ParameterDiffs);
        WriteObject(outputObject);
    }
}
