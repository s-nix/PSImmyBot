using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProvisioningPackageOptions")]
public class NewProvisioningPackageOptions : Cmdlet {
    [Parameter(Mandatory = true)] public required bool DisableHibernation { get; set; }
    [Parameter(Mandatory = true)] public required bool DownloadIso { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableCleanPc { get; set; }
    [Parameter(Mandatory = true)] public required bool EncryptPackage { get; set; }
    [Parameter(Mandatory = true)] public required bool HideAdminAccount { get; set; }
    [Parameter(Mandatory = false)] public string? LocalAdminPassword { get; set; }
    [Parameter(Mandatory = false)] public string? LocalAdminUsername { get; set; }
    [Parameter(Mandatory = false)] public string? PackagePassword { get; set; }
    [Parameter(Mandatory = true)] public required bool SetupAdmin { get; set; }
    [Parameter(Mandatory = true)] public required bool SetupWireless { get; set; }
    [Parameter(Mandatory = false)] public string? WirelessKey { get; set; }
    [Parameter(Mandatory = false)] public bool? WirelessOpen { get; set; }
    [Parameter(Mandatory = false)] public string? WirelessSsid { get; set; }

    protected override void ProcessRecord() {
        ProvisioningPackageOptions outputObject = new(DisableHibernation, DownloadIso, EnableCleanPc, EncryptPackage, HideAdminAccount, LocalAdminPassword, LocalAdminUsername, PackagePassword, SetupAdmin, SetupWireless, WirelessKey, WirelessOpen, WirelessSsid);
        WriteObject(outputObject);
    }
}
