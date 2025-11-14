using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetLocalSoftwareVersionResponse")]
public class NewGetLocalSoftwareVersionResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion DependsOnSemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public int? DeprecatedIdField { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayVersion { get; set; }
    [Parameter(Mandatory = true)] public required bool HasOverrides { get; set; }
    [Parameter(Mandatory = false)] public string? InstallerFile { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareVersionInstallerType InstallerType { get; set; }
    [Parameter(Mandatory = false)] public int? InstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType InstallScriptType { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceActionResult LastResult { get; set; }
    [Parameter(Mandatory = true)] public required LicenseType LicenseType { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required int NumActionFailures { get; set; }
    [Parameter(Mandatory = true)] public required int NumActionSuccesses { get; set; }
    [Parameter(Mandatory = false)] public string? PackageHash { get; set; }
    [Parameter(Mandatory = true)] public required PackageType PackageType { get; set; }
    [Parameter(Mandatory = false)] public int? PostInstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostInstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? PostUninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostUninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public string? ProductCode { get; set; }
    [Parameter(Mandatory = false)] public string? RelativeCacheSourcePath { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SemanticVersionString { get; set; }
    [Parameter(Mandatory = true)] public required GetLocalSoftwareResponse Software { get; set; }
    [Parameter(Mandatory = true)] public required int SoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public string? TestFailedError { get; set; }
    [Parameter(Mandatory = true)] public required bool TestRequired { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TestScriptType { get; set; }
    [Parameter(Mandatory = true)] public required bool UninstallIfNotInTarget { get; set; }
    [Parameter(Mandatory = false)] public int? UninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public int? UpgradeScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UpgradeScriptType { get; set; }
    [Parameter(Mandatory = true)] public required UpdateActionType UpgradeStrategy { get; set; }
    [Parameter(Mandatory = false)] public string? Url { get; set; }

    protected override void ProcessRecord() {
        GetLocalSoftwareVersionResponse outputObject = new(BlobName, CreatedDateUtc, DependsOnSemanticVersion, DeprecatedIdField, DisplayName, DisplayVersion, HasOverrides, InstallerFile, InstallerType, InstallScriptId, InstallScriptType, LastResult, LicenseType, Notes, NumActionFailures, NumActionSuccesses, PackageHash, PackageType, PostInstallScriptId, PostInstallScriptType, PostUninstallScriptId, PostUninstallScriptType, ProductCode, RelativeCacheSourcePath, SemanticVersion, SemanticVersionString, Software, SoftwareId, SoftwareIdentifier, SoftwareType, TestFailedError, TestRequired, TestScriptId, TestScriptType, UninstallIfNotInTarget, UninstallScriptId, UninstallScriptType, UpdatedBy, UpdatedDateUtc, UpgradeScriptId, UpgradeScriptType, UpgradeStrategy, Url);
        WriteObject(outputObject);
    }
}
