using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CommandResult(
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("success")]
    bool Success);
