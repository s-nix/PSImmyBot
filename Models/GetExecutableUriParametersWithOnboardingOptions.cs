using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetExecutableUriParametersWithOnboardingOptions(
    [property: JsonPropertyName("onboardingOptions")]
    [property: System.ComponentModel.DataAnnotations.Required]
    AgentOnboardingOptions OnboardingOptions,
    [property: JsonPropertyName("targetExternalClientId")]
    string? TargetExternalClientId);
