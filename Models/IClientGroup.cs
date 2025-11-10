using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IClientGroup(
    [property: JsonPropertyName("clientGroupDisplayName")]
    string? ClientGroupDisplayName,
    [property: JsonPropertyName("clientGroupId")]
    string? ClientGroupId);
