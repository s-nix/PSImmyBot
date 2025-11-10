using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateApplicationLogSourceContextRequest(
    [property: JsonPropertyName("minimumLevel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<LogLevel>))]
    LogLevel MinimumLevel,
    [property: JsonPropertyName("sourceContext")]
    string? SourceContext);
