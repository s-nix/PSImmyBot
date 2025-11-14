using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetPowerShellInstallScriptParametersWithOnboardingOptions")]
public class NewGetPowerShellInstallScriptParametersWithOnboardingOptions : Cmdlet {
    [Parameter(Mandatory = true)] public required AgentOnboardingOptions OnboardingOptions { get; set; }
    [Parameter(Mandatory = true)] public required Platform Platform { get; set; }
    [Parameter(Mandatory = false)] public string? TargetExternalClientId { get; set; }

    protected override void ProcessRecord() {
        GetPowerShellInstallScriptParametersWithOnboardingOptions outputObject = new(OnboardingOptions, Platform, TargetExternalClientId);
        WriteObject(outputObject);
    }
}
