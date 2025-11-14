using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ReleaseDetails(
    [property: JsonPropertyName("immyAgentInstallerFileVersion")]
    string? ImmyAgentInstallerFileVersion,
    [property: JsonPropertyName("immyAgentInstallerVersion")]
    SemanticVersion ImmyAgentInstallerVersion,
    [property: JsonPropertyName("publishedDate")]
    DateTimeOffset? PublishedDate,
    [property: JsonPropertyName("releaseChannel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ReleaseChannel>))]
    ReleaseChannel ReleaseChannel,
    [property: JsonPropertyName("releaseNotes")]
    string? ReleaseNotes, [property: JsonPropertyName("tag")] SemanticVersion Tag);
