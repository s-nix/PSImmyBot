using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputersReinventory")]
public class SendComputersReinventory : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/reinventory?";

        InventoryDeviceCmdResponse response = ImmyBotApiService.Post<InventoryDeviceCmdResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
