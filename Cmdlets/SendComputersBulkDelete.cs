using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputersBulkDelete")]
public class SendComputersBulkDelete : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required BulkDeleteRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/computers/bulk-delete?";
        BulkDeleteResponse response = ImmyBotApiService
            .Post<BulkDeleteRequest, BulkDeleteResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
