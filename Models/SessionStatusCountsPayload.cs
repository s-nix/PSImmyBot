using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SessionStatusCountsPayload([property: JsonPropertyName("counts")] IDictionary<string, int>? Counts, [property: JsonPropertyName("total")] double Total);
