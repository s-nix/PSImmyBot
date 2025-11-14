using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ResolveAssignmentsForMaintenanceItemResultItem")]
public class NewResolveAssignmentsForMaintenanceItemResultItem : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required int DeploymentId { get; set; }
    [Parameter(Mandatory = false)] public string? DeploymentPhrase { get; set; }

    protected override void ProcessRecord() {
        ResolveAssignmentsForMaintenanceItemResultItem outputObject = new(DatabaseType, DeploymentId, DeploymentPhrase);
        WriteObject(outputObject);
    }
}
