using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SetPreflightScriptEnablementRequest(
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("isEnabled")]
    bool IsEnabled,
    [property: JsonPropertyName("scriptId")]
    int ScriptId);
