using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalTargetAssignmentResource")]
public class GetLocalTargetAssignmentResource : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/{Id}?";

        LocalTargetAssignmentResource response = ImmyBotApiService.Get<LocalTargetAssignmentResource>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
