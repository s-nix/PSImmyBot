using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IClientStatus(
    [property: JsonPropertyName("clientStatusDisplayName")]
    string? ClientStatusDisplayName,
    [property: JsonPropertyName("clientStatusId")]
    string? ClientStatusId);
