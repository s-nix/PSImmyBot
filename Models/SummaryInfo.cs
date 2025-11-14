using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SummaryInfo(
    [property: JsonPropertyName("selector")] string? Selector,
    [property: JsonPropertyName("summaryType")] string? SummaryType
    );
