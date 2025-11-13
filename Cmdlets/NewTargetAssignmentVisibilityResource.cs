using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TargetAssignmentVisibilityResource")]
public class NewTargetAssignmentVisibilityResource : Cmdlet {
    [Parameter(Mandatory = true)] public required bool SelfService { get; set; }
    [Parameter(Mandatory = true)] public required bool TechnicianPod { get; set; }

    protected override void ProcessRecord() {
        TargetAssignmentVisibilityResource outputObject = new(SelfService, TechnicianPod);
        WriteObject(outputObject);
    }
}
