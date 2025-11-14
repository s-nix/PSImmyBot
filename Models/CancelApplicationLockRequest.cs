using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CancelApplicationLockRequest(
    [property: JsonPropertyName("cancelReason")]
    string? CancelReason, [property: JsonPropertyName("key")] string? Key);
