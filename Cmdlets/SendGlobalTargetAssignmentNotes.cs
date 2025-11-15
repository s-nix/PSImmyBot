using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GlobalTargetAssignmentNotes")]
public class SendGlobalTargetAssignmentNotes : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

    [Parameter(Mandatory = true)]
    public required UpdateNotesPayload PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/target-assignments/global/{Id}/notes?";
        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }
}
