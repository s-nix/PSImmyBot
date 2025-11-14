using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateGlobalMediaPayload(
    [property: JsonPropertyName("blobReference")]
    string? BlobReference,
    [property: JsonPropertyName("category")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MediaCategory>))]
    MediaCategory Category,
    [property: JsonPropertyName("fileName")]
    string? FileName, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("mimeType")]
    string? MimeType, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("packageHash")]
    string? PackageHash,
    [property: JsonPropertyName("relativeCacheSourcePath")]
    string? RelativeCacheSourcePath);
