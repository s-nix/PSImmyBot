using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputerNotesUpdate")]
public class SendComputerNotesUpdate : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }

    [Parameter(Mandatory = true)]
    public required UpdateNotesPayload PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/computers/{ComputerId}/notes?";
        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }
}
