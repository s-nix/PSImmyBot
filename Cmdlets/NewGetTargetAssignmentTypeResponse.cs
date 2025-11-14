using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetTargetAssignmentTypeResponse")]
public class NewGetTargetAssignmentTypeResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowAccessToParentTenant { get; set; }
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required bool PropagateToChildTenants { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required TargetEnforcement TargetEnforcement { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }

    protected override void ProcessRecord() {
        GetTargetAssignmentTypeResponse outputObject = new(AllowAccessToParentTenant, DesiredSoftwareState, MaintenanceTaskMode, PropagateToChildTenants, Target, TargetEnforcement, TargetType, TenantId);
        WriteObject(outputObject);
    }
}
