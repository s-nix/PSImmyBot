using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DuplicateAssignmentRequestBody(
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType, [property: JsonPropertyName("id")] int Id);
