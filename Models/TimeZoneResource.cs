using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TimeZoneResource(
    [property: JsonPropertyName("displayName")]
    string? DisplayName, [property: JsonPropertyName("id")] string? Id);
