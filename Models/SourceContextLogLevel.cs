using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SourceContextLogLevel(
    [property: JsonPropertyName("logLevel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<LogLevel>))]
    LogLevel LogLevel,
    [property: JsonPropertyName("sourceContext")]
    string? SourceContext);
