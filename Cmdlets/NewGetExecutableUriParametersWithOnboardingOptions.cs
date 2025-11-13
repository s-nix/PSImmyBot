using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetExecutableUriParametersWithOnboardingOptions")]
public class NewGetExecutableUriParametersWithOnboardingOptions : Cmdlet {
    [Parameter(Mandatory = true)] public required AgentOnboardingOptions OnboardingOptions { get; set; }
    [Parameter(Mandatory = false)] public string? TargetExternalClientId { get; set; }

    protected override void ProcessRecord() {
        GetExecutableUriParametersWithOnboardingOptions outputObject = new(OnboardingOptions, TargetExternalClientId);
        WriteObject(outputObject);
    }
}
