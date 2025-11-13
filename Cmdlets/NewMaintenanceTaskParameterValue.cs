using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceTaskParameterValue")]
public class NewMaintenanceTaskParameterValue : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowOverrideFromComputerOnboarding { get; set; }
    [Parameter(Mandatory = true)] public required TargetAssignment Deployment { get; set; }
    [Parameter(Mandatory = true)] public required int DeploymentId { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTask MaintenanceTask { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskParameter MaintenanceTaskParameter { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceTaskParameterId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }
    [Parameter(Mandatory = true)] public required Media Media { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MediaDatabaseType { get; set; }
    [Parameter(Mandatory = false)] public int? MediaId { get; set; }
    [Parameter(Mandatory = false)] public string? ParameterName { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskParameterType ParameterType { get; set; }
    [Parameter(Mandatory = false)] public string? Value { get; set; }

    protected override void ProcessRecord() {
        MaintenanceTaskParameterValue outputObject = new(AllowOverrideFromComputerOnboarding, Deployment, DeploymentId, Id, MaintenanceTask, MaintenanceTaskId, MaintenanceTaskParameter, MaintenanceTaskParameterId, MaintenanceTaskType, Media, MediaDatabaseType, MediaId, ParameterName, ParameterType, Value);
        WriteObject(outputObject);
    }
}
