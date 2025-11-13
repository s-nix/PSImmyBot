using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateLocalSoftwareVersionRequestBody")]
public class NewUpdateLocalSoftwareVersionRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobName { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion CurrentSemanticVersion { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion DependsOnSemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayVersion { get; set; }
    [Parameter(Mandatory = false)] public string? InstallerFile { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareVersionInstallerType InstallerType { get; set; }
    [Parameter(Mandatory = false)] public int? InstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType InstallScriptType { get; set; }
    [Parameter(Mandatory = true)] public required LicenseType LicenseType { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = false)] public string? PackageHash { get; set; }
    [Parameter(Mandatory = true)] public required PackageType PackageType { get; set; }
    [Parameter(Mandatory = false)] public int? PostInstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostInstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? PostUninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType PostUninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public string? ProductCode { get; set; }
    [Parameter(Mandatory = false)] public string? RelativeCacheSourcePath { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = true)] public required int SoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public string? TestFailedError { get; set; }
    [Parameter(Mandatory = true)] public required bool TestRequired { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TestScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? UninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UninstallScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? UpgradeScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType UpgradeScriptType { get; set; }
    [Parameter(Mandatory = true)] public required UpdateActionType UpgradeStrategy { get; set; }
    [Parameter(Mandatory = false)] public string? Url { get; set; }

    protected override void ProcessRecord() {
        UpdateLocalSoftwareVersionRequestBody outputObject = new(BlobName, CurrentSemanticVersion, DependsOnSemanticVersion, DisplayName, DisplayVersion, InstallerFile, InstallerType, InstallScriptId, InstallScriptType, LicenseType, Notes, PackageHash, PackageType, PostInstallScriptId, PostInstallScriptType, PostUninstallScriptId, PostUninstallScriptType, ProductCode, RelativeCacheSourcePath, SemanticVersion, SoftwareId, SoftwareIdentifier, SoftwareType, TestFailedError, TestRequired, TestScriptId, TestScriptType, UninstallScriptId, UninstallScriptType, UpgradeScriptId, UpgradeScriptType, UpgradeStrategy, Url);
        WriteObject(outputObject);
    }
}
