using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ValidateParamBlockParametersFromTaskRequest")]
public class NewValidateParamBlockParametersFromTaskRequest : Cmdlet {
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DeploymentDatabaseType { get; set; }
    [Parameter(Mandatory = false)] public int? DeploymentId { get; set; }
    [Parameter(Mandatory = true)] public required bool ForceRebind { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, ParameterValue>? ParameterValues { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public Guid? TerminalId { get; set; }

    protected override void ProcessRecord() {
        ValidateParamBlockParametersFromTaskRequest outputObject = new(ComputerId, DatabaseType, DeploymentDatabaseType, DeploymentId, ForceRebind, MaintenanceSessionId, MaintenanceTaskId, ParameterValues, PersonId, TenantId, TerminalId);
        WriteObject(outputObject);
    }
}
