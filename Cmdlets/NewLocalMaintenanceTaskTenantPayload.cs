using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LocalMaintenanceTaskTenantPayload")]
public class NewLocalMaintenanceTaskTenantPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required Relationship Relationship { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        LocalMaintenanceTaskTenantPayload outputObject = new(Relationship, TenantId);
        WriteObject(outputObject);
    }
}
