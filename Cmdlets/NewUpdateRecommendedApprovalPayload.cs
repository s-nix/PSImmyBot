using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateRecommendedApprovalPayload")]
public class NewUpdateRecommendedApprovalPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Approved { get; set; }
    [Parameter(Mandatory = true)] public required int GlobalTargetAssignmentId { get; set; }

    protected override void ProcessRecord() {
        UpdateRecommendedApprovalPayload outputObject = new(Approved, GlobalTargetAssignmentId);
        WriteObject(outputObject);
    }
}
