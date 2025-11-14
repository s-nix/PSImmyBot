using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChangeRequestParameterDiff([property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("newValue")]
    DeploymentParameterValue NewValue,
    [property: JsonPropertyName("oldValue")]
    DeploymentParameterValue OldValue);
