using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TargetAssignmentVisibilityPayload")]
public class NewTargetAssignmentVisibilityPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required bool SelfService { get; set; }
    [Parameter(Mandatory = true)] public required bool TechnicianPod { get; set; }

    protected override void ProcessRecord() {
        TargetAssignmentVisibilityPayload outputObject = new(SelfService, TechnicianPod);
        WriteObject(outputObject);
    }
}
