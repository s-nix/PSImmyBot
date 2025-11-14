using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetPendingCountsResponse(
    [property: JsonPropertyName("active")] int Active,
    [property: JsonPropertyName("failed")] int Failed,
    [property: JsonPropertyName("manual")] int Manual,
    [property: JsonPropertyName("offline")]
    int Offline,
    [property: JsonPropertyName("recent")] int Recent, [property: JsonPropertyName("total")] int Total);
