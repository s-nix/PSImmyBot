using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetSessionStatusCountsPayload([property: JsonPropertyName("counts")] IDictionary<string, int>? Counts, [property: JsonPropertyName("total")] double Total);
