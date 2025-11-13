using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceItemOrder")]
public class GetMaintenanceItemOrder : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/target-assignments/maintenance-item-orders?";

        List<MaintenanceItemOrder> response = ImmyBotApiService.Get<List<MaintenanceItemOrder>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
