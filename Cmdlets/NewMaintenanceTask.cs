using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceTask")]
public class NewMaintenanceTask : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required bool ExecuteSerially { get; set; }
    [Parameter(Mandatory = true)] public required bool GetEnabled { get; set; }
    [Parameter(Mandatory = true)] public required Script GetScript { get; set; }
    [Parameter(Mandatory = false)] public int? GetScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType GetScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Media Icon { get; set; }
    [Parameter(Mandatory = false)] public int? IconMediaId { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IgnoreDuringAutomaticOnboarding { get; set; }
    [Parameter(Mandatory = false)] public Guid? IntegrationTypeId { get; set; }
    [Parameter(Mandatory = true)] public required bool IsConfigurationTask { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskCategory MaintenanceTaskCategory { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingOnly { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceTaskParameter>? Parameters { get; set; }
    [Parameter(Mandatory = true)] public required bool Recommended { get; set; }
    [Parameter(Mandatory = true)] public required bool SetEnabled { get; set; }
    [Parameter(Mandatory = true)] public required Script SetScript { get; set; }
    [Parameter(Mandatory = false)] public int? SetScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType SetScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? SupersededByTaskId { get; set; }
    [Parameter(Mandatory = false)] public int? SupersededByTaskMigrationScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType SupersededByTaskMigrationScriptType { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType SupersededByTaskType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantMaintenanceTask>? TenantRelationships { get; set; }
    [Parameter(Mandatory = true)] public required bool TestEnabled { get; set; }
    [Parameter(Mandatory = true)] public required Script TestScript { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TestScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required bool UseScriptParamBlock { get; set; }

    protected override void ProcessRecord() {
        MaintenanceTask outputObject = new(CreatedBy, CreatedByUser, CreatedDate, DatabaseType, ExecuteSerially, GetEnabled, GetScript, GetScriptId, GetScriptType, Icon, IconMediaId, Id, IgnoreDuringAutomaticOnboarding, IntegrationTypeId, IsConfigurationTask, MaintenanceTaskCategory, MaintenanceType, Name, Notes, OnboardingOnly, Parameters, Recommended, SetEnabled, SetScript, SetScriptId, SetScriptType, SupersededByTaskId, SupersededByTaskMigrationScriptId, SupersededByTaskMigrationScriptType, SupersededByTaskType, TenantRelationships, TestEnabled, TestScript, TestScriptId, TestScriptType, UpdatedBy, UpdatedByUser, UpdatedDate, UseScriptParamBlock);
        WriteObject(outputObject);
    }
}
