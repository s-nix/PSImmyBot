using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateOptionalTargetAssignmentApprovalPayload")]
public class SendUpdateOptionalTargetAssignmentApprovalPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateOptionalTargetAssignmentApprovalPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/optional-target-assignment-approvals/{Id}?";

        bool response = ImmyBotApiService.Post<UpdateOptionalTargetAssignmentApprovalPayload, bool>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
