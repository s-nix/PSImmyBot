using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateLocalInventoryTask")]
public class SendCreateLocalInventoryTask : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required InventoryTaskPayload PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/inventory-tasks/local?";
        InventoryTaskResource response = ImmyBotApiService
            .Post<InventoryTaskPayload, InventoryTaskResource>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
