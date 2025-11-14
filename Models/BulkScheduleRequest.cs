using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkScheduleRequest(
    [property: JsonPropertyName("scheduleIds")]
    ICollection<int>? ScheduleIds);
