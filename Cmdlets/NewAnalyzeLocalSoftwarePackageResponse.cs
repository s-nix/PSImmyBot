using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AnalyzeLocalSoftwarePackageResponse")]
public class NewAnalyzeLocalSoftwarePackageResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required IScriptDetailsBase BatchInstallScript { get; set; }
    [Parameter(Mandatory = true)] public required IScriptDetailsBase DefaultPowershellUninstallScript { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required IScriptDetailsBase DetectionScript { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayVersion { get; set; }
    [Parameter(Mandatory = false)] public string? Extension { get; set; }
    [Parameter(Mandatory = false)] public string? FileName { get; set; }
    [Parameter(Mandatory = true)] public required bool IsExe { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMsi { get; set; }
    [Parameter(Mandatory = false)] public string? PackageHash { get; set; }
    [Parameter(Mandatory = true)] public required PackageType PackageType { get; set; }
    [Parameter(Mandatory = true)] public required IScriptDetailsBase PowerShellInstallScript { get; set; }
    [Parameter(Mandatory = true)] public required IScriptDetailsBase PowerShellUninstallScript { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProductCode { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareTableName { get; set; }
    [Parameter(Mandatory = false)] public Guid? UpgradeCode { get; set; }

    protected override void ProcessRecord() {
        AnalyzeLocalSoftwarePackageResponse outputObject = new(BatchInstallScript, DefaultPowershellUninstallScript, Description, DetectionScript, DisplayVersion, Extension, FileName, IsExe, IsMsi, PackageHash, PackageType, PowerShellInstallScript, PowerShellUninstallScript, ProductCode, SoftwareTableName, UpgradeCode);
        WriteObject(outputObject);
    }
}
