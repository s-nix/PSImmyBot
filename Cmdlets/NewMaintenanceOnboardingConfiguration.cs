using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MaintenanceOnboardingConfiguration")]
public class NewMaintenanceOnboardingConfiguration : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<MaintenanceTaskParameterValueDetails>? OnboardingOnlyMaintenanceTaskParameterValueOverrides { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? OnboardingOnlyParameterValueOverrides { get; set; }
    [Parameter(Mandatory = true)] public required bool AutomaticOnboarding { get; set; }

    protected override void ProcessRecord() {
        MaintenanceOnboardingConfiguration outputObject = new(OnboardingOnlyParameterValueOverrides, OnboardingOnlyMaintenanceTaskParameterValueOverrides, AutomaticOnboarding);
        WriteObject(outputObject);
    }
}
