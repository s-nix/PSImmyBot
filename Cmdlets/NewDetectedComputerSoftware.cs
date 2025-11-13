using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DetectedComputerSoftware")]
public class NewDetectedComputerSoftware : Cmdlet {
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareRegistryContext Context { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DetectedAt { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayIcon { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayVersion { get; set; }
    [Parameter(Mandatory = false)] public int? GlobalSoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? GlobalSoftwareName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? InstallDate { get; set; }
    [Parameter(Mandatory = false)] public string? InstallLocation { get; set; }
    [Parameter(Mandatory = false)] public string? OriginalKey { get; set; }
    [Parameter(Mandatory = false)] public string? Platform { get; set; }
    [Parameter(Mandatory = true)] public required Person PrimaryPerson { get; set; }
    [Parameter(Mandatory = false)] public int? PrimaryPersonId { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProductCode { get; set; }
    [Parameter(Mandatory = false)] public string? QuietUninstallString { get; set; }
    [Parameter(Mandatory = false)] public string? RegistryPath { get; set; }
    [Parameter(Mandatory = false)] public int? SystemComponent { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? UninstallString { get; set; }
    [Parameter(Mandatory = false)] public Guid? UpgradeCode { get; set; }
    [Parameter(Mandatory = false)] public string? UserName { get; set; }
    [Parameter(Mandatory = false)] public string? UserSid { get; set; }

    protected override void ProcessRecord() {
        DetectedComputerSoftware outputObject = new(Computer, ComputerId, Context, DetectedAt, DisplayIcon, DisplayName, DisplayVersion, GlobalSoftwareId, GlobalSoftwareName, Id, InstallDate, InstallLocation, OriginalKey, Platform, PrimaryPerson, PrimaryPersonId, ProductCode, QuietUninstallString, RegistryPath, SystemComponent, Tenant, TenantId, UninstallString, UpgradeCode, UserName, UserSid);
        WriteObject(outputObject);
    }
}
