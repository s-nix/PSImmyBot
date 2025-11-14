using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ParameterDropdownTextValue([property: JsonPropertyName("text")] string? Text, [property: JsonPropertyName("value")] string? Value);
