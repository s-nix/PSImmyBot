using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetRecommendedApprovalResponse")]
public class NewGetRecommendedApprovalResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Approved { get; set; }
    [Parameter(Mandatory = false)] public string? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int GlobalTargetAssignmentId { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetRecommendedApprovalResponse outputObject = new(Approved, CreatedBy, CreatedDateUtc, GlobalTargetAssignmentId, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
