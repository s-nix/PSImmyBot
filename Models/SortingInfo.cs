using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SortingInfo(
    [property: JsonPropertyName("desc")] bool Desc,
    [property: JsonPropertyName("selector")] string? Selector
    );
