using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ResolveVisibilityTargetAssignmentsRequest")]
public class NewResolveVisibilityTargetAssignmentsRequest : Cmdlet {
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = true)] public required TargetVisibility Visibility { get; set; }

    protected override void ProcessRecord() {
        ResolveVisibilityTargetAssignmentsRequest outputObject = new(ComputerId, PersonId, TenantId, Visibility);
        WriteObject(outputObject);
    }
}
