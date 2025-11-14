using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DetectedComputerSoftwareResponse")]
public class NewDetectedComputerSoftwareResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DetectedAt { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? InstallDate { get; set; }
    [Parameter(Mandatory = false)] public string? InstallLocation { get; set; }
    [Parameter(Mandatory = false)] public string? PersonEmail { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public string? PersonName { get; set; }
    [Parameter(Mandatory = false)] public string? Platform { get; set; }
    [Parameter(Mandatory = false)] public Guid? ProductCode { get; set; }
    [Parameter(Mandatory = false)] public string? QuietUninstallString { get; set; }
    [Parameter(Mandatory = false)] public string? RegistryPath { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareName { get; set; }
    [Parameter(Mandatory = false)] public int? SystemComponent { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public string? UninstallString { get; set; }
    [Parameter(Mandatory = false)] public Guid? UpgradeCode { get; set; }
    [Parameter(Mandatory = false)] public string? Version { get; set; }

    protected override void ProcessRecord() {
        DetectedComputerSoftwareResponse outputObject = new(ComputerId, ComputerName, DetectedAt, Id, InstallDate, InstallLocation, PersonEmail, PersonId, PersonName, Platform, ProductCode, QuietUninstallString, RegistryPath, SoftwareId, SoftwareName, SystemComponent, TenantId, TenantName, UninstallString, UpgradeCode, Version);
        WriteObject(outputObject);
    }
}
