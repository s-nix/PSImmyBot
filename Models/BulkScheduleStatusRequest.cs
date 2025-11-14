using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkScheduleStatusRequest(
    [property: JsonPropertyName("disabled")]
    bool Disabled,
    [property: JsonPropertyName("scheduleIds")]
    ICollection<int>? ScheduleIds);
