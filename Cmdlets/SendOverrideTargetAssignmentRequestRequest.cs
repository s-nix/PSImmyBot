using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "OverrideTargetAssignmentRequestRequest")]
public class SendOverrideTargetAssignmentRequestRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required OverrideTargetAssignmentRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/global/{Id}/override?";

        LocalTargetAssignmentResource response = ImmyBotApiService.Post<OverrideTargetAssignmentRequest, LocalTargetAssignmentResource>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
