using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateRecommendedApprovalsRequestBody")]
public class NewUpdateRecommendedApprovalsRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<UpdateRecommendedApprovalPayload>? Approvals { get; set; }

    protected override void ProcessRecord() {
        UpdateRecommendedApprovalsRequestBody outputObject = new(Approvals);
        WriteObject(outputObject);
    }
}
