using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetPendingResponse([property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("results")]
    ICollection<GetPendingAgentResponse>? Results);
