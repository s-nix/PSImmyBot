using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ResolveAssignmentsForMaintenanceItemRequest")]
public class NewResolveAssignmentsForMaintenanceItemRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        ResolveAssignmentsForMaintenanceItemRequest outputObject = new(MaintenanceIdentifier, MaintenanceType, TenantId);
        WriteObject(outputObject);
    }
}
