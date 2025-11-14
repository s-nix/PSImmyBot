using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateGlobalTargetAssignmentPayload")]
public class PushUpdateGlobalTargetAssignmentPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateGlobalTargetAssignmentPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/global/{Id}?";

        GlobalTargetAssignmentResource response = ImmyBotApiService.Put<UpdateGlobalTargetAssignmentPayload, GlobalTargetAssignmentResource>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
