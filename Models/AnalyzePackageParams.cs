using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AnalyzePackageParams(
    [property: JsonPropertyName("blobName")]
    string? BlobName,
    [property: JsonPropertyName("fileName")]
    string? FileName,
    [property: JsonPropertyName("url")] string? Url);
