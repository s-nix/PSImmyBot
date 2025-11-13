using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "InventoryTaskScriptPayload")]
public class SendInventoryTaskScriptPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required InventoryTaskScriptPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/inventory-tasks/local/{Id}/scripts?";

        InventoryTaskScriptResource response = ImmyBotApiService.Post<InventoryTaskScriptPayload, InventoryTaskScriptResource>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
