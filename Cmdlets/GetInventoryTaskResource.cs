using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "InventoryTaskResource")]
public class GetInventoryTaskResource : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/inventory-tasks?";

        List<InventoryTaskResource> response = ImmyBotApiService.Get<List<InventoryTaskResource>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
