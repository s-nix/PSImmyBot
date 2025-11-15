using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "PersonsRemoveTags")]
public class SendPersonsRemoveTags : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required RemoveTagsRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/persons/remove-tags?";
        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }
}
