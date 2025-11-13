using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GlobalSoftwareVersion")]
public class NewGlobalSoftwareVersion : Cmdlet {
    [Parameter(Mandatory = true)] public required Architecture Architecture { get; set; }
    [Parameter(Mandatory = false)] public string? BlobName { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion DependsOnSemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public int? DeprecatedIdField { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayVersion { get; set; }
    [Parameter(Mandatory = false)] public string? InstallerFile { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareVersionInstallerType InstallerType { get; set; }
    [Parameter(Mandatory = true)] public required Script InstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? InstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType InstallScriptType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResult LastResult { get; set; }
    [Parameter(Mandatory = true)] public required LicenseType LicenseType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required int NumActionFailures { get; set; }
    [Parameter(Mandatory = true)] public required int NumActionSuccesses { get; set; }
    [Parameter(Mandatory = false)] public string? PackageHash { get; set; }
    [Parameter(Mandatory = true)] public required PackageType PackageType { get; set; }
    [Parameter(Mandatory = true)] public required Script PostInstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? PostInstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostInstallScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Script PostUninstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? PostUninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostUninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public string? ProductCode { get; set; }
    [Parameter(Mandatory = false)] public string? RelativeCacheSourcePath { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SemanticVersionString { get; set; }
    [Parameter(Mandatory = true)] public required GlobalSoftware Software { get; set; }
    [Parameter(Mandatory = true)] public required int SoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public string? TestFailedError { get; set; }
    [Parameter(Mandatory = true)] public required bool TestRequired { get; set; }
    [Parameter(Mandatory = true)] public required Script TestScript { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TestScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Script UninstallScript { get; set; }
    [Parameter(Mandatory = false)] public int? UninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required Script UpgradeScript { get; set; }
    [Parameter(Mandatory = false)] public int? UpgradeScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UpgradeScriptType { get; set; }
    [Parameter(Mandatory = true)] public required UpdateActionType UpgradeStrategy { get; set; }
    [Parameter(Mandatory = false)] public string? Url { get; set; }

    protected override void ProcessRecord() {
        GlobalSoftwareVersion outputObject = new(Architecture, BlobName, CreatedBy, CreatedDate, DependsOnSemanticVersion, DeprecatedIdField, DisplayName, DisplayVersion, InstallerFile, InstallerType, InstallScript, InstallScriptId, InstallScriptType, LastResult, LicenseType, MaintenanceType, Notes, NumActionFailures, NumActionSuccesses, PackageHash, PackageType, PostInstallScript, PostInstallScriptId, PostInstallScriptType, PostUninstallScript, PostUninstallScriptId, PostUninstallScriptType, ProductCode, RelativeCacheSourcePath, SemanticVersion, SemanticVersionString, Software, SoftwareId, SoftwareIdentifier, SoftwareType, TestFailedError, TestRequired, TestScript, TestScriptId, TestScriptType, UninstallScript, UninstallScriptId, UninstallScriptType, UpdatedBy, UpdatedDate, UpgradeScript, UpgradeScriptId, UpgradeScriptType, UpgradeStrategy, Url);
        WriteObject(outputObject);
    }
}
