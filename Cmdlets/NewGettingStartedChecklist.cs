using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GettingStartedChecklist")]
public class NewGettingStartedChecklist : Cmdlet {
    [Parameter(Mandatory = true)] public required bool ActivatedTrial { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableGettingStartedWizard { get; set; }
    [Parameter(Mandatory = true)] public required bool InstalledImmyAgent { get; set; }
    [Parameter(Mandatory = true)] public required bool RanOnboardingSession { get; set; }

    protected override void ProcessRecord() {
        GettingStartedChecklist outputObject = new(ActivatedTrial, EnableGettingStartedWizard, InstalledImmyAgent, RanOnboardingSession);
        WriteObject(outputObject);
    }
}
