using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceTasksReferenceCount")]
public class GetMaintenanceTasksReferenceCount : Cmdlet {
    [Parameter(Mandatory = false)]
    public DatabaseType? MaintenanceTaskType { get; set; }

    [Parameter(Mandatory = false)]
    public int? MaintenanceTaskId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/maintenance-tasks/reference-count?";
        endpoint += Globals.ConvertToQueryParameters(MaintenanceTaskType, "maintenanceTaskType");
        endpoint += Globals.ConvertToQueryParameters(MaintenanceTaskId, "maintenanceTaskId");

        int response = ImmyBotApiService.Get<int>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
