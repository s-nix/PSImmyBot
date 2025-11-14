using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MediaSearchResponse([property: JsonPropertyName("global")] ICollection<GlobalMediaResponse>? Global, [property: JsonPropertyName("local")] ICollection<LocalMediaResponse>? Local);
