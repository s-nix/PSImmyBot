using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateLocalSoftwareRequestBody")]
public class NewUpdateLocalSoftwareRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public Guid? AgentIntegrationTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? ChocoProviderSoftwareId { get; set; }
    [Parameter(Mandatory = true)] public required DetectionMethod DetectionMethod { get; set; }
    [Parameter(Mandatory = false)] public int? DetectionScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DetectionScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? DownloadInstallerScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DownloadInstallerScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? DynamicVersionsScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DynamicVersionsScriptType { get; set; }
    [Parameter(Mandatory = true)] public required bool Hidden { get; set; }
    [Parameter(Mandatory = true)] public required int InstallOrder { get; set; }
    [Parameter(Mandatory = false)] public int? InstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType InstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public string? LicenseDescription { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareLicenseRequirement LicenseRequirement { get; set; }
    [Parameter(Mandatory = true)] public required LicenseType LicenseType { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? NiniteProviderSoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = false)] public int? OwnerTenantId { get; set; }
    [Parameter(Mandatory = false)] public int? PostInstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostInstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? PostUninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostUninstallScriptType { get; set; }
    [Parameter(Mandatory = true)] public required bool RebootNeeded { get; set; }
    [Parameter(Mandatory = true)] public required bool Recommended { get; set; }
    [Parameter(Mandatory = false)] public int? RepairScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType RepairScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? RepairType { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareIconMediaId { get; set; }
    [Parameter(Mandatory = true)] public required int SoftwareId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SoftwarePrerequisite>? SoftwarePrerequisites { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareTableName { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareTableNameSearchMode SoftwareTableNameSearchMode { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? TenantSoftware { get; set; }
    [Parameter(Mandatory = false)] public string? TestFailedError { get; set; }
    [Parameter(Mandatory = true)] public required bool TestRequired { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TestScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? UninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public string? UpgradeCode { get; set; }
    [Parameter(Mandatory = false)] public int? UpgradeScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UpgradeScriptType { get; set; }
    [Parameter(Mandatory = true)] public required UpdateActionType UpgradeStrategy { get; set; }
    [Parameter(Mandatory = true)] public required bool UseDynamicVersions { get; set; }

    protected override void ProcessRecord() {
        UpdateLocalSoftwareRequestBody outputObject = new(AgentIntegrationTypeId, ChocoProviderSoftwareId, DetectionMethod, DetectionScriptId, DetectionScriptType, DownloadInstallerScriptId, DownloadInstallerScriptType, DynamicVersionsScriptId, DynamicVersionsScriptType, Hidden, InstallOrder, InstallScriptId, InstallScriptType, LicenseDescription, LicenseRequirement, LicenseType, MaintenanceTaskId, MaintenanceTaskType, Name, NiniteProviderSoftwareId, Notes, OwnerTenantId, PostInstallScriptId, PostInstallScriptType, PostUninstallScriptId, PostUninstallScriptType, RebootNeeded, Recommended, RepairScriptId, RepairScriptType, RepairType, SoftwareIconMediaId, SoftwareId, SoftwarePrerequisites, SoftwareTableName, SoftwareTableNameSearchMode, TenantSoftware, TestFailedError, TestRequired, TestScriptId, TestScriptType, UninstallScriptId, UninstallScriptType, UpgradeCode, UpgradeScriptId, UpgradeScriptType, UpgradeStrategy, UseDynamicVersions);
        WriteObject(outputObject);
    }
}
