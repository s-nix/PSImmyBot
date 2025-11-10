using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MyComputerResponse([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline, [property: JsonPropertyName("name")] string? Name);
