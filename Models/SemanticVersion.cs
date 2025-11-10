using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SemanticVersion(
    [property: JsonPropertyName("hasMetadata")]
    bool HasMetadata,
    [property: JsonPropertyName("isPrerelease")]
    bool IsPrerelease, [property: JsonPropertyName("major")] int Major,
    [property: JsonPropertyName("metadata")]
    string? Metadata, [property: JsonPropertyName("minor")] int Minor, [property: JsonPropertyName("patch")] int Patch,
    [property: JsonPropertyName("release")]
    string? Release,
    [property: JsonPropertyName("releaseLabels")]
    ICollection<string>? ReleaseLabels);
