using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetProvisioningPackageUriParameters(
    [property: JsonPropertyName("ppkgOptions")]
    [property: System.ComponentModel.DataAnnotations.Required]
    ProvisioningPackageOptions PpkgOptions,
    [property: JsonPropertyName("targetExternalClientId")]
    string? TargetExternalClientId);
