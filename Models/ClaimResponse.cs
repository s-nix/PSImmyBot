using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ClaimResponse([property: JsonPropertyName("type")] string? Type, [property: JsonPropertyName("value")] string? Value);
