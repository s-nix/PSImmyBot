using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetOptionalTargetAssignmentApprovalResponse")]
public class NewGetOptionalTargetAssignmentApprovalResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required TargetAssignmentApprovalStatus Approved { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required int TargetAssignmentId { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetOptionalTargetAssignmentApprovalResponse outputObject = new(Approved, CreatedBy, CreatedDateUtc, Id, MaintenanceType, Target, TargetAssignmentId, TargetType, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
