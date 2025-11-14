using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ExcludeFromMaintenanceRequest")]
public class SendExcludeFromMaintenanceRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    [Parameter(Mandatory = true)] public required ExcludeFromMaintenanceRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/exclude-from-maintenance?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
