using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AppRegistrationOption(
    [property: JsonPropertyName("clientId")]
    string? ClientId,
    [property: JsonPropertyName("displayName")]
    string? DisplayName);
