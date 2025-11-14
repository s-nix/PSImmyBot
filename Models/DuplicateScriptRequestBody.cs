using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DuplicateScriptRequestBody([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("scriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType ScriptType);
