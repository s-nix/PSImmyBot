using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeploymentParameterValue(
    [property: JsonPropertyName("allowOverride")]
    bool? AllowOverride,
    [property: JsonPropertyName("requiresOverride")]
    bool? RequiresOverride, [property: JsonPropertyName("value")] object? Value);
