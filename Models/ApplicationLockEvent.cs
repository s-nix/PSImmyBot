using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ApplicationLockEvent (
    [property: JsonPropertyName("key")] string? Key,
    [property: JsonPropertyName("eventType")] int EventType,
    [property: JsonPropertyName("callerInfo")] string CallerInfo,
    [property: JsonPropertyName("eventTimestamp")] DateTimeOffset EventTimestamp,
    [property: JsonPropertyName("reason")] string? Reason);
