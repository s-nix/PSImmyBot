using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetMaintenanceSessionLogResponse")]
public class NewGetMaintenanceSessionLogResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPrimary { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceActionId { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionStatus MaintenanceActionStatus { get; set; }
    [Parameter(Mandatory = true)] public required int MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceSessionStageId { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? ParamBlockParameters { get; set; }
    [Parameter(Mandatory = false)] public string? ProgressActivity { get; set; }
    [Parameter(Mandatory = true)] public required bool ProgressCompleted { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProgressCorrelationId { get; set; }
    [Parameter(Mandatory = false)] public string? ProgressCurrentOperation { get; set; }
    [Parameter(Mandatory = false)] public double? ProgressPercentComplete { get; set; }
    [Parameter(Mandatory = false)] public double? ProgressSecondsRemaining { get; set; }
    [Parameter(Mandatory = false)] public string? ProgressStatus { get; set; }
    [Parameter(Mandatory = false)] public string? Script { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = false)] public int? ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = false)] public string? ScriptOutput { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? ScriptParameters { get; set; }
    [Parameter(Mandatory = false)] public int? ScriptTimeout { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = true)] public required SessionLogType SessionLogType { get; set; }
    [Parameter(Mandatory = false)] public int? SessionPhaseId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset Time { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? UpdatedTime { get; set; }

    protected override void ProcessRecord() {
        GetMaintenanceSessionLogResponse outputObject = new(Id, IsPrimary, MaintenanceActionId, MaintenanceActionStatus, MaintenanceSessionId, MaintenanceSessionStageId, Message, ParamBlockParameters, ProgressActivity, ProgressCompleted, ProgressCorrelationId, ProgressCurrentOperation, ProgressPercentComplete, ProgressSecondsRemaining, ProgressStatus, Script, ScriptExecutionContext, ScriptId, ScriptLanguage, ScriptOutput, ScriptParameters, ScriptTimeout, ScriptType, SessionLogType, SessionPhaseId, Time, UpdatedTime);
        WriteObject(outputObject);
    }
}
