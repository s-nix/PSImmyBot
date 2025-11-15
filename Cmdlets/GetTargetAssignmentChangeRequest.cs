using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TargetAssignmentChangeRequest")]
public class GetTargetAssignmentChangeRequest : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ChangeRequestId { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/target-assignments/change-request/{ChangeRequestId}?";

        ChangeRequestResponse response = ImmyBotApiService.Get<ChangeRequestResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
