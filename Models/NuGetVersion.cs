using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record NuGetVersion(
    [property: JsonPropertyName("hasMetadata")]
    bool HasMetadata,
    [property: JsonPropertyName("isLegacyVersion")]
    bool IsLegacyVersion,
    [property: JsonPropertyName("isPrerelease")]
    bool IsPrerelease,
    [property: JsonPropertyName("isSemVer2")]
    bool IsSemVer2,
    [property: JsonPropertyName("major")] int Major,
    [property: JsonPropertyName("metadata")]
    string? Metadata,
    [property: JsonPropertyName("minor")] int Minor,
    [property: JsonPropertyName("originalVersion")]
    string? OriginalVersion,
    [property: JsonPropertyName("patch")] int Patch,
    [property: JsonPropertyName("release")]
    string? Release,
    [property: JsonPropertyName("releaseLabels")]
    ICollection<string>? ReleaseLabels,
    [property: JsonPropertyName("revision")]
    int Revision,
    [property: JsonPropertyName("version")]
    string? Version);
