using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "InventoryTasksLocalScripts")]
public class RemoveInventoryTasksLocalScripts : Cmdlet {
    [Parameter(Mandatory = true)]
    public required int TaskId { get; set; }

     [Parameter(Mandatory = true)]
    public required string InventoryKey { get; set; }

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/inventory-tasks/local/{TaskId}/scripts/{InventoryKey}?";

        InventoryTaskResource response = ImmyBotApiService.Delete<InventoryTaskResource>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
