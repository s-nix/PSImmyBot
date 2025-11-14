using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ApplicationLocksResponse([property: JsonPropertyName("key")] string? Key,
    [property: JsonPropertyName("lockHolder")]
    ApplicationLockCallerInfo LockHolder,
    [property: JsonPropertyName("lockWaiters")]
    ICollection<ApplicationLockCallerInfo>? LockWaiters);
