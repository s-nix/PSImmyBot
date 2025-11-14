using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerLatestProviderEvent(
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("lastProviderAgentEventDateUtc")]
    DateTimeOffset LastProviderAgentEventDateUtc);
