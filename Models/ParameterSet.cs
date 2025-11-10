using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ParameterSet(
    [property: JsonPropertyName("isDefault")]
    bool IsDefault, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("parameters")]
    ICollection<Parameter>? Parameters);
