using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputersAddTags")]
public class SendComputersAddTags : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required AddTagsRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/computers/add-tags?";
        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }
}
