using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ScriptReference(
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType, [property: JsonPropertyName("id")] int Id, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("scriptReferenceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptReferenceType>))]
    ScriptReferenceType ScriptReferenceType,
    [property: JsonPropertyName("softwareVersion")]
    SemanticVersion SoftwareVersion);
