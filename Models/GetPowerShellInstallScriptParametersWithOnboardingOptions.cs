using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetPowerShellInstallScriptParametersWithOnboardingOptions(
    [property: JsonPropertyName("onboardingOptions")]
    [property: System.ComponentModel.DataAnnotations.Required]
    AgentOnboardingOptions OnboardingOptions,
    [property: JsonPropertyName("platform")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Platform>))]
    Platform Platform,
    [property: JsonPropertyName("targetExternalClientId")]
    string? TargetExternalClientId);
