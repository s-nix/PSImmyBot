using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetProvisioningPackageUriParametersWithOnboardingOptions(
    [property: JsonPropertyName("onboardingOptions")]
    [property: System.ComponentModel.DataAnnotations.Required]
    AgentOnboardingOptions OnboardingOptions,
    [property: JsonPropertyName("ppkgOptions")]
    [property: System.ComponentModel.DataAnnotations.Required]
    ProvisioningPackageOptions PpkgOptions,
    [property: JsonPropertyName("targetExternalClientId")]
    string? TargetExternalClientId);
