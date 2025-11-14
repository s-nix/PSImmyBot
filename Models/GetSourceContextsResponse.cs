using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetSourceContextsResponse(
    [property: JsonPropertyName("sourceContextLogLevels")]
    ICollection<SourceContextLogLevel>? SourceContextLogLevels,
    [property: JsonPropertyName("streamingEnabled")]
    bool StreamingEnabled);
