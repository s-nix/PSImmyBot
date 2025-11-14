using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceActionDependency")]
public class NewMaintenanceActionDependency : Cmdlet {
    [Parameter(Mandatory = true)] public required MaintenanceAction Dependent { get; set; }
    [Parameter(Mandatory = true)] public required int DependentId { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceAction DependsOn { get; set; }
    [Parameter(Mandatory = true)] public required int DependsOnId { get; set; }

    protected override void ProcessRecord() {
        MaintenanceActionDependency outputObject = new(Dependent, DependentId, DependsOn, DependsOnId);
        WriteObject(outputObject);
    }
}
