using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record StartEditorServicesRequest(
    [property: JsonPropertyName("scriptCategory")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptCategory>))]
    ScriptCategory ScriptCategory,
    [property: JsonPropertyName("scriptExecutionContext")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptExecutionContext>))]
    ScriptExecutionContext ScriptExecutionContext,
    [property: JsonPropertyName("scriptId")]
    int? ScriptId,
    [property: JsonPropertyName("scriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType ScriptType,
    [property: JsonPropertyName("terminalId")]
    Guid TerminalId);
