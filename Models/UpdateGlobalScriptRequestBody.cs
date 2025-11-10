using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateGlobalScriptRequestBody([property: JsonPropertyName("action")] string? Action, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("outputType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptOutputType>))]
    ScriptOutputType OutputType,
    [property: JsonPropertyName("scriptCategory")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptCategory>))]
    ScriptCategory ScriptCategory,
    [property: JsonPropertyName("scriptExecutionContext")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptExecutionContext>))]
    ScriptExecutionContext ScriptExecutionContext,
    [property: JsonPropertyName("scriptLanguage")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptLanguage>))]
    ScriptLanguage ScriptLanguage,
    [property: JsonPropertyName("scriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType ScriptType,
    [property: JsonPropertyName("timeout")]
    int? Timeout);
