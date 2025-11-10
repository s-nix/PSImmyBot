using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChocoPackageVersion([property: JsonPropertyName("id")] string? Id,
    [property: JsonPropertyName("semanticVersion")]
    NuGetVersion SemanticVersion,
    [property: JsonPropertyName("title")] string? Title,
    [property: JsonPropertyName("version")]
    string? Version);
