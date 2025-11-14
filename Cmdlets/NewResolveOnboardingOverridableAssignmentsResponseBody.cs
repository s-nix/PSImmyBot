using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ResolveOnboardingOverridableAssignmentsResponseBody")]
public class NewResolveOnboardingOverridableAssignmentsResponseBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<TargetAssignmentResource>? NextHighestPriorityNonOnboardingOnlyAssignments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TargetAssignmentResource>? OverridableAssignments { get; set; }

    protected override void ProcessRecord() {
        ResolveOnboardingOverridableAssignmentsResponseBody outputObject = new(NextHighestPriorityNonOnboardingOnlyAssignments, OverridableAssignments);
        WriteObject(outputObject);
    }
}
