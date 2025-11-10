using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RegistryKeyDto(
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("fullPath")]
    string? FullPath,
    [property: JsonPropertyName("subKeyCount")]
    int SubKeyCount,
    [property: JsonPropertyName("valueCount")]
    int ValueCount);
