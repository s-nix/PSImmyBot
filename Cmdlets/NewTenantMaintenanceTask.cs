using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantMaintenanceTask")]
public class NewTenantMaintenanceTask : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceTask MaintenanceTask { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = true)] public required Relationship Relationship { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        TenantMaintenanceTask outputObject = new(MaintenanceTask, MaintenanceTaskId, Relationship, Tenant, TenantId);
        WriteObject(outputObject);
    }
}
