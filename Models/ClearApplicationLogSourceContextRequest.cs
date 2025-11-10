using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ClearApplicationLogSourceContextRequest(
    [property: JsonPropertyName("sourceContext")]
    string? SourceContext);
