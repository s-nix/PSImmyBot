using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceTaskParameterValueDetails")]
public class NewMaintenanceTaskParameterValueDetails : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowOverrideFromComputerOnboarding { get; set; }
    [Parameter(Mandatory = true)] public required int DeploymentId { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceTaskParameterId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MediaDatabaseType { get; set; }
    [Parameter(Mandatory = false)] public int? MediaId { get; set; }
    [Parameter(Mandatory = false)] public string? ParameterName { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskParameterType ParameterType { get; set; }
    [Parameter(Mandatory = false)] public string? Value { get; set; }

    protected override void ProcessRecord() {
        MaintenanceTaskParameterValueDetails outputObject = new(AllowOverrideFromComputerOnboarding, DeploymentId, Id, MaintenanceTaskId, MaintenanceTaskParameterId, MaintenanceTaskType, MediaDatabaseType, MediaId, ParameterName, ParameterType, Value);
        WriteObject(outputObject);
    }
}
