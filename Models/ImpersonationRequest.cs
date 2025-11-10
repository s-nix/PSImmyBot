using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ImpersonationRequest(
    [property: JsonPropertyName("expiresAtUtc")]
    DateTimeOffset ExpiresAtUtc);
