using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetBashInstallScriptParameters(
    [property: JsonPropertyName("platform")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Platform>))]
    Platform Platform,
    [property: JsonPropertyName("targetExternalClientId")]
    string? TargetExternalClientId);
