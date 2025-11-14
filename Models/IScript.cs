using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IScript(
    [property: JsonPropertyName("script")] string? Script,
    [property: JsonPropertyName("scriptLanguage")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptLanguage>))]
    ScriptLanguage ScriptLanguage,
    [property: JsonPropertyName("timeout")]
    int Timeout);
