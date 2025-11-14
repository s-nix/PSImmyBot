using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateGlobalSoftwareRequestBody")]
public class NewCreateGlobalSoftwareRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public Guid? AgentIntegrationTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? ChocoProviderSoftwareId { get; set; }
    [Parameter(Mandatory = true)] public required DetectionMethod DetectionMethod { get; set; }
    [Parameter(Mandatory = false)] public int? DetectionScriptId { get; set; }
    [Parameter(Mandatory = false)] public int? DownloadInstallerScriptId { get; set; }
    [Parameter(Mandatory = false)] public int? DynamicVersionsScriptId { get; set; }
    [Parameter(Mandatory = true)] public required bool Hidden { get; set; }
    [Parameter(Mandatory = true)] public required int InstallOrder { get; set; }
    [Parameter(Mandatory = false)] public int? InstallScriptId { get; set; }
    [Parameter(Mandatory = false)] public string? LicenseDescription { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareLicenseRequirement LicenseRequirement { get; set; }
    [Parameter(Mandatory = true)] public required LicenseType LicenseType { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceTaskId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? NiniteProviderSoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = false)] public int? PostInstallScriptId { get; set; }
    [Parameter(Mandatory = false)] public int? PostUninstallScriptId { get; set; }
    [Parameter(Mandatory = true)] public required bool RebootNeeded { get; set; }
    [Parameter(Mandatory = true)] public required bool Recommended { get; set; }
    [Parameter(Mandatory = false)] public int? RepairScriptId { get; set; }
    [Parameter(Mandatory = false)] public int? RepairType { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareIconMediaId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SoftwarePrerequisite>? SoftwarePrerequisites { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareTableName { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareTableNameSearchMode SoftwareTableNameSearchMode { get; set; }
    [Parameter(Mandatory = false)] public string? TestFailedError { get; set; }
    [Parameter(Mandatory = true)] public required bool TestRequired { get; set; }
    [Parameter(Mandatory = false)] public int? TestScriptId { get; set; }
    [Parameter(Mandatory = false)] public int? UninstallScriptId { get; set; }
    [Parameter(Mandatory = false)] public string? UpgradeCode { get; set; }
    [Parameter(Mandatory = false)] public int? UpgradeScriptId { get; set; }
    [Parameter(Mandatory = true)] public required UpdateActionType UpgradeStrategy { get; set; }
    [Parameter(Mandatory = true)] public required bool UseDynamicVersions { get; set; }

    protected override void ProcessRecord() {
        CreateGlobalSoftwareRequestBody outputObject = new(AgentIntegrationTypeId, ChocoProviderSoftwareId, DetectionMethod, DetectionScriptId, DownloadInstallerScriptId, DynamicVersionsScriptId, Hidden, InstallOrder, InstallScriptId, LicenseDescription, LicenseRequirement, LicenseType, MaintenanceTaskId, Name, NiniteProviderSoftwareId, Notes, PostInstallScriptId, PostUninstallScriptId, RebootNeeded, Recommended, RepairScriptId, RepairType, SoftwareIconMediaId, SoftwarePrerequisites, SoftwareTableName, SoftwareTableNameSearchMode, TestFailedError, TestRequired, TestScriptId, UninstallScriptId, UpgradeCode, UpgradeScriptId, UpgradeStrategy, UseDynamicVersions);
        WriteObject(outputObject);
    }
}
