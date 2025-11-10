using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record MaintenanceOnboardingConfiguration {
    [JsonConstructor]
    [Obsolete]
    public MaintenanceOnboardingConfiguration(bool @automaticOnboarding, ICollection<MaintenanceTaskParameterValueDetails>? @onboardingOnlyMaintenanceTaskParameterValueOverrides, IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? @onboardingOnlyParameterValueOverrides) {
        OnboardingOnlyParameterValueOverrides = @onboardingOnlyParameterValueOverrides;
        OnboardingOnlyMaintenanceTaskParameterValueOverrides = @onboardingOnlyMaintenanceTaskParameterValueOverrides;
        AutomaticOnboarding = @automaticOnboarding;
    }

    [JsonPropertyName("onboardingOnlyParameterValueOverrides")]
    public IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? OnboardingOnlyParameterValueOverrides { get; init; }

    [JsonPropertyName("onboardingOnlyMaintenanceTaskParameterValueOverrides")]
    [Obsolete]
    public ICollection<MaintenanceTaskParameterValueDetails>? OnboardingOnlyMaintenanceTaskParameterValueOverrides { get; init; }

    [JsonPropertyName("automaticOnboarding")]
    public bool AutomaticOnboarding { get; init; }
}
