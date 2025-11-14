using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateLocalTargetAssignmentPayload")]
public class PushUpdateLocalTargetAssignmentPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateLocalTargetAssignmentPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/{Id}?";

        LocalTargetAssignmentResource response = ImmyBotApiService.Put<UpdateLocalTargetAssignmentPayload, LocalTargetAssignmentResource>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
