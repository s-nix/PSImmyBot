using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GettingStartedChecklist(
    [property: JsonPropertyName("activatedTrial")]
    bool ActivatedTrial,
    [property: JsonPropertyName("enableGettingStartedWizard")]
    bool EnableGettingStartedWizard,
    [property: JsonPropertyName("installedImmyAgent")]
    bool InstalledImmyAgent,
    [property: JsonPropertyName("ranOnboardingSession")]
    bool RanOnboardingSession);
