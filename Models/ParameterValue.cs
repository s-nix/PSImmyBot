using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ParameterValue([property: JsonPropertyName("value")] object? Value);
