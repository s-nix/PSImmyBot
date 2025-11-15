using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TargetAssignmentChangeRequests")]
public class GetTargetAssignmentChangeRequests : Cmdlet
{
    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/target-assignments/change-requests?";

        List<ChangeRequestResponse> response = ImmyBotApiService.Get<List<ChangeRequestResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
