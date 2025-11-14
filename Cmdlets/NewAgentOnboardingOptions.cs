using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AgentOnboardingOptions")]
public class NewAgentOnboardingOptions : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? AdditionalPersonIds { get; set; }
    [Parameter(Mandatory = true)] public required bool AutomaticallyOnboard { get; set; }
    [Parameter(Mandatory = true)] public required bool IsDevLab { get; set; }
    [Parameter(Mandatory = false)] public string? OnboardingCorrelationId { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingSessionAutoConsentToReboots { get; set; }
    [Parameter(Mandatory = true)] public required PromptTimeoutAction OnboardingSessionPromptTimeoutAction { get; set; }
    [Parameter(Mandatory = true)] public required int OnboardingSessionPromptTimeoutMinutes { get; set; }
    [Parameter(Mandatory = true)] public required RebootPreference OnboardingSessionRebootPreference { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingSessionSendFollowUpEmail { get; set; }
    [Parameter(Mandatory = false)] public int? PrimaryPersonId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? Tags { get; set; }

    protected override void ProcessRecord() {
        AgentOnboardingOptions outputObject = new(AdditionalPersonIds, AutomaticallyOnboard, IsDevLab, OnboardingCorrelationId, OnboardingSessionAutoConsentToReboots, OnboardingSessionPromptTimeoutAction, OnboardingSessionPromptTimeoutMinutes, OnboardingSessionRebootPreference, OnboardingSessionSendFollowUpEmail, PrimaryPersonId, Tags);
        WriteObject(outputObject);
    }
}
