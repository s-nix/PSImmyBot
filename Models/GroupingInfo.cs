using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GroupingInfo(
    [property: JsonPropertyName("desc")] bool Desc,
    [property: JsonPropertyName("groupInterval")] string? GroupInterval,
    [property: JsonPropertyName("isExpanded")] bool? IsExpanded,
    [property: JsonPropertyName("selector")] string? Selector);
