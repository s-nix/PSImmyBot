using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LocalSoftware")]
public class NewLocalSoftware : Cmdlet {
    [Parameter(Mandatory = false)] public Guid? AgentIntegrationTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? ChocoProviderSoftwareId { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AuditPropertyChange>? CustomAuditProperties { get; set; }
    [Parameter(Mandatory = true)] public required DetectionMethod DetectionMethod { get; set; }
    [Parameter(Mandatory = true)] public required Script DetectionScript { get; set; }
    [Parameter(Mandatory = false)] public int? DetectionScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DetectionScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Script DownloadInstallerScript { get; set; }
    [Parameter(Mandatory = false)] public int? DownloadInstallerScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DownloadInstallerScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Script DynamicVersionsScript { get; set; }
    [Parameter(Mandatory = false)] public int? DynamicVersionsScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DynamicVersionsScriptType { get; set; }
    [Parameter(Mandatory = true)] public required bool Hidden { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Identifier { get; set; }
    [Parameter(Mandatory = true)] public required int InstallOrder { get; set; }
    [Parameter(Mandatory = true)] public required Script InstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? InstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType InstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public string? LicenseDescription { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareLicenseRequirement LicenseRequirement { get; set; }
    [Parameter(Mandatory = true)] public required LicenseType LicenseType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceSpecifier MaintenanceSpecifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTask MaintenanceTask { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType MaintenanceTaskType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? NiniteProviderSoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = false)] public int? OwnerTenantId { get; set; }
    [Parameter(Mandatory = true)] public required Script PostInstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? PostInstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostInstallScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Script PostUninstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? PostUninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostUninstallScriptType { get; set; }
    [Parameter(Mandatory = true)] public required bool RebootNeeded { get; set; }
    [Parameter(Mandatory = true)] public required bool Recommended { get; set; }
    [Parameter(Mandatory = true)] public required Guid RelativeCacheSourcePath { get; set; }
    [Parameter(Mandatory = true)] public required Script RepairScript { get; set; }
    [Parameter(Mandatory = false)] public int? RepairScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType RepairScriptType { get; set; }
    [Parameter(Mandatory = true)] public required RepairActionType RepairType { get; set; }
    [Parameter(Mandatory = true)] public required Media SoftwareIcon { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareIconMediaId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SoftwarePrerequisite>? SoftwarePrerequisites { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareTableName { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareTableNameSearchMode SoftwareTableNameSearchMode { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LocalSoftwareVersion>? SoftwareVersions { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantSoftware>? TenantSoftware { get; set; }
    [Parameter(Mandatory = false)] public string? TestFailedError { get; set; }
    [Parameter(Mandatory = true)] public required bool TestRequired { get; set; }
    [Parameter(Mandatory = true)] public required Script TestScript { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TestScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Script UninstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? UninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = false)] public string? UpgradeCode { get; set; }
    [Parameter(Mandatory = true)] public required Script UpgradeScript { get; set; }
    [Parameter(Mandatory = false)] public int? UpgradeScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UpgradeScriptType { get; set; }
    [Parameter(Mandatory = true)] public required UpdateActionType UpgradeStrategy { get; set; }
    [Parameter(Mandatory = true)] public required bool UseDynamicVersions { get; set; }
    [Parameter(Mandatory = true)] public required bool UseSoftwareTableDetection { get; set; }

    protected override void ProcessRecord() {
        LocalSoftware outputObject = new(AgentIntegrationTypeId, ChocoProviderSoftwareId, CreatedBy, CreatedByUser, CreatedDate, CustomAuditProperties, DetectionMethod, DetectionScript, DetectionScriptId, DetectionScriptType, DownloadInstallerScript, DownloadInstallerScriptId, DownloadInstallerScriptType, DynamicVersionsScript, DynamicVersionsScriptId, DynamicVersionsScriptType, Hidden, Id, Identifier, InstallOrder, InstallScript, InstallScriptId, InstallScriptType, LicenseDescription, LicenseRequirement, LicenseType, MaintenanceSpecifier, MaintenanceTask, MaintenanceTaskId, MaintenanceTaskType, MaintenanceType, Name, NiniteProviderSoftwareId, Notes, OwnerTenantId, PostInstallScript, PostInstallScriptId, PostInstallScriptType, PostUninstallScript, PostUninstallScriptId, PostUninstallScriptType, RebootNeeded, Recommended, RelativeCacheSourcePath, RepairScript, RepairScriptId, RepairScriptType, RepairType, SoftwareIcon, SoftwareIconMediaId, SoftwarePrerequisites, SoftwareTableName, SoftwareTableNameSearchMode, SoftwareType, SoftwareVersions, TenantSoftware, TestFailedError, TestRequired, TestScript, TestScriptId, TestScriptType, UninstallScript, UninstallScriptId, UninstallScriptType, UpdatedBy, UpdatedByUser, UpdatedDate, UpgradeCode, UpgradeScript, UpgradeScriptId, UpgradeScriptType, UpgradeStrategy, UseDynamicVersions, UseSoftwareTableDetection);
        WriteObject(outputObject);
    }
}
