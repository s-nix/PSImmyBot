using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ProviderAgentsBulkDeletePending")]
public class SendProviderAgentsBulkDeletePending : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required BulkDeleteRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/provider-agents/bulk-delete-pending?";
        BulkDeleteResponse response = ImmyBotApiService
            .Post<BulkDeleteRequest, BulkDeleteResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
