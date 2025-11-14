using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetExecutableUriParameters(
    [property: JsonPropertyName("targetExternalClientId")]
    string? TargetExternalClientId);
