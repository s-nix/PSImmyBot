using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetProvisioningPackageUriParameters")]
public class NewGetProvisioningPackageUriParameters : Cmdlet {
    [Parameter(Mandatory = true)] public required ProvisioningPackageOptions PpkgOptions { get; set; }
    [Parameter(Mandatory = false)] public string? TargetExternalClientId { get; set; }

    protected override void ProcessRecord() {
        GetProvisioningPackageUriParameters outputObject = new(PpkgOptions, TargetExternalClientId);
        WriteObject(outputObject);
    }
}
