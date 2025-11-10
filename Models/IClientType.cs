using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IClientType(
    [property: JsonPropertyName("clientTypeDisplayName")]
    string? ClientTypeDisplayName,
    [property: JsonPropertyName("clientTypeId")]
    string? ClientTypeId);
