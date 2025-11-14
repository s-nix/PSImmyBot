using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetProvisioningPackageUriParametersWithOnboardingOptions")]
public class NewGetProvisioningPackageUriParametersWithOnboardingOptions : Cmdlet {
    [Parameter(Mandatory = true)] public required AgentOnboardingOptions OnboardingOptions { get; set; }
    [Parameter(Mandatory = true)] public required ProvisioningPackageOptions PpkgOptions { get; set; }
    [Parameter(Mandatory = false)] public string? TargetExternalClientId { get; set; }

    protected override void ProcessRecord() {
        GetProvisioningPackageUriParametersWithOnboardingOptions outputObject = new(OnboardingOptions, PpkgOptions, TargetExternalClientId);
        WriteObject(outputObject);
    }
}
