using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ApplicationLockCallerInfo(
    [property: JsonPropertyName("id")] Guid Id,
    [property: JsonPropertyName("isLockHolder")] bool IsLockHolder,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("since")] DateTimeOffset Since);
