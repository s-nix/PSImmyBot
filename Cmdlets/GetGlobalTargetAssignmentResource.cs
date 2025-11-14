using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalTargetAssignmentResource")]
public class GetGlobalTargetAssignmentResource : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/target-assignments/global/{Id}?";

        GlobalTargetAssignmentResource response = ImmyBotApiService.Get<GlobalTargetAssignmentResource>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
