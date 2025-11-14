using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserImpersonation(
    [property: JsonPropertyName("expiresAtUtc")]
    DateTimeOffset ExpiresAtUtc, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("impersonatingUser")]
    User ImpersonatingUser,
    [property: JsonPropertyName("impersonatingUserId")]
    int ImpersonatingUserId,
    [property: JsonPropertyName("impersonatorUser")]
    User ImpersonatorUser,
    [property: JsonPropertyName("impersonatorUserId")]
    int ImpersonatorUserId);
