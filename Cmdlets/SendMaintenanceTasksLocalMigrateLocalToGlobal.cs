using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MaintenanceTasksLocalMigrateLocalToGlobal")]
public class SendMaintenanceTasksLocalMigrateLocalToGlobal : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/local/{Id}/migrate-local-to-global?";

        int response = ImmyBotApiService.Post<int>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
