using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DisabledPreflightScriptResponse(
    [property: JsonPropertyName("databaseType")]
    [property: System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("scriptId")]
    int ScriptId);
