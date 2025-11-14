using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkScheduleOperationResult(
    [property: JsonPropertyName("errorMessage")]
    string? ErrorMessage,
    [property: JsonPropertyName("scheduleId")]
    int ScheduleId,
    [property: JsonPropertyName("success")]
    bool Success);
