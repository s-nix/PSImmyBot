using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RecommendedTargetAssignmentApproval")]
public class NewRecommendedTargetAssignmentApproval : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Approved { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int GlobalTargetAssignmentId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        RecommendedTargetAssignmentApproval outputObject = new(Approved, CreatedBy, CreatedByUser, CreatedDate, GlobalTargetAssignmentId, UpdatedBy, UpdatedByUser, UpdatedDate);
        WriteObject(outputObject);
    }
}
