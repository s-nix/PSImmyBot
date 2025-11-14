using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "OverrideTargetAssignmentRequest")]
public class NewOverrideTargetAssignmentRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }

    protected override void ProcessRecord() {
        OverrideTargetAssignmentRequest outputObject = new(DesiredSoftwareState, Target, TargetType);
        WriteObject(outputObject);
    }
}
