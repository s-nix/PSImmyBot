using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateOptionalTargetAssignmentApprovalPayload")]
public class NewUpdateOptionalTargetAssignmentApprovalPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required TargetAssignmentApprovalStatus Approved { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required int TargetAssignmentId { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }

    protected override void ProcessRecord() {
        UpdateOptionalTargetAssignmentApprovalPayload outputObject = new(Approved, MaintenanceType, Target, TargetAssignmentId, TargetType);
        WriteObject(outputObject);
    }
}
