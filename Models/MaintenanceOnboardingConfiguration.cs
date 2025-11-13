using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceOnboardingConfiguration(
    [property: JsonPropertyName("onboardingOnlyParameterValueOverrides")]
    IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? OnboardingOnlyParameterValueOverrides,

    [property: JsonPropertyName("onboardingOnlyMaintenanceTaskParameterValueOverrides")]
    [property: Obsolete]
    ICollection<MaintenanceTaskParameterValueDetails>? OnboardingOnlyMaintenanceTaskParameterValueOverrides,

    [property: JsonPropertyName("automaticOnboarding")]
    bool AutomaticOnboarding
);
