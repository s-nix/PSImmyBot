using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TargetAssignmentVisibility")]
public class NewTargetAssignmentVisibility : Cmdlet {
    [Parameter(Mandatory = true)] public required bool SelfService { get; set; }
    [Parameter(Mandatory = true)] public required TargetAssignment TargetAssignment { get; set; }
    [Parameter(Mandatory = true)] public required int TargetAssignmentId { get; set; }
    [Parameter(Mandatory = true)] public required bool TechnicianPod { get; set; }

    protected override void ProcessRecord() {
        TargetAssignmentVisibility outputObject = new(SelfService, TargetAssignment, TargetAssignmentId, TechnicianPod);
        WriteObject(outputObject);
    }
}
