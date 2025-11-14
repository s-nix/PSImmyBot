using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetGlobalMaintenanceTaskResponse")]
public class NewGetGlobalMaintenanceTaskResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required bool ExecuteSerially { get; set; }
    [Parameter(Mandatory = true)] public required bool GetEnabled { get; set; }
    [Parameter(Mandatory = false)] public int? GetScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType GetScriptType { get; set; }
    [Parameter(Mandatory = true)] public required MediaResponseBase Icon { get; set; }
    [Parameter(Mandatory = false)] public int? IconMediaId { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IgnoreDuringAutomaticOnboarding { get; set; }
    [Parameter(Mandatory = false)] public Guid? IntegrationTypeId { get; set; }
    [Parameter(Mandatory = true)] public required bool IsConfigurationTask { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskCategory MaintenanceTaskCategory { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingOnly { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetMaintenanceTaskParameterResponse>? Parameters { get; set; }
    [Parameter(Mandatory = true)] public required bool Recommended { get; set; }
    [Parameter(Mandatory = true)] public required bool SetEnabled { get; set; }
    [Parameter(Mandatory = false)] public int? SetScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType SetScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? SupersededByTaskId { get; set; }
    [Parameter(Mandatory = false)] public int? SupersededByTaskMigrationScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType SupersededByTaskMigrationScriptType { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType SupersededByTaskType { get; set; }
    [Parameter(Mandatory = true)] public required bool TestEnabled { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TestScriptType { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool UseScriptParamBlock { get; set; }

    protected override void ProcessRecord() {
        GetGlobalMaintenanceTaskResponse outputObject = new(CreatedDateUtc, DatabaseType, ExecuteSerially, GetEnabled, GetScriptId, GetScriptType, Icon, IconMediaId, Id, IgnoreDuringAutomaticOnboarding, IntegrationTypeId, IsConfigurationTask, MaintenanceTaskCategory, Name, Notes, OnboardingOnly, Parameters, Recommended, SetEnabled, SetScriptId, SetScriptType, SupersededByTaskId, SupersededByTaskMigrationScriptId, SupersededByTaskMigrationScriptType, SupersededByTaskType, TestEnabled, TestScriptId, TestScriptType, UpdatedDateUtc, UseScriptParamBlock);
        WriteObject(outputObject);
    }
}
