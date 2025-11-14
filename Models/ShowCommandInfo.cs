using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ShowCommandInfo(
    [property: JsonPropertyName("definition")]
    string? Definition,
    [property: JsonPropertyName("parameterSets")]
    ICollection<ParameterSet>? ParameterSets);
