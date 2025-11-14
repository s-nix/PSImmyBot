using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetFileDownloadUrlRequest(
    [property: JsonPropertyName("blobName")]
    string? BlobName,
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType);
