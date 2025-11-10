using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChocoSearchResult([property: JsonPropertyName("id")] string? Id, [property: JsonPropertyName("title")] string? Title);
