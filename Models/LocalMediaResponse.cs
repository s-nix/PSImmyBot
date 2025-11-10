using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LocalMediaResponse(
    [property: JsonPropertyName("blobReference")]
    string? BlobReference,
    [property: JsonPropertyName("category")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MediaCategory>))]
    MediaCategory Category,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("fileName")]
    string? FileName,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("mimeType")]
    string? MimeType,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("owned")] bool Owned,
    [property: JsonPropertyName("packageHash")]
    string? PackageHash,
    [property: JsonPropertyName("relativeCacheSourcePath")]
    string? RelativeCacheSourcePath,
    [property: JsonPropertyName("tenants")]
    ICollection<TenantMedia>? Tenants,
    [property: JsonPropertyName("updatedBy")]
    string? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc);
