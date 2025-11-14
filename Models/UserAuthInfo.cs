using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserAuthInfo(
    [property: JsonPropertyName("expirationDate")]
    DateTimeOffset ExpirationDate,
    [property: JsonPropertyName("expirationSecondsSinceEpoch")]
    long ExpirationSecondsSinceEpoch,
    [property: JsonPropertyName("userDisplayName")]
    string? UserDisplayName,
    [property: JsonPropertyName("userEmailAddress")]
    string? UserEmailAddress);
