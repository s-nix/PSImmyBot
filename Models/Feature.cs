using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Feature(
    [property: JsonPropertyName("enabled")]
    bool Enabled,
    [property: JsonPropertyName("name")] string? Name);
