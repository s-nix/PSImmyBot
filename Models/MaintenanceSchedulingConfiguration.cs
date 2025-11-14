using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceSchedulingConfiguration(
    [property: JsonPropertyName("maintenanceTime")]
    string? MaintenanceTime,
    [property: JsonPropertyName("offlineBehavior")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ComputerOfflineMaintenanceSessionBehavior>))]
    ComputerOfflineMaintenanceSessionBehavior OfflineBehavior,
    [property: JsonPropertyName("scheduleExecutionAfterActiveHours")]
    bool ScheduleExecutionAfterActiveHours, [property: JsonPropertyName("time")] string? Time,
    [property: JsonPropertyName("timeZoneInfoId")]
    string? TimeZoneInfoId,
    [property: JsonPropertyName("useComputersTimezoneForExecution")]
    bool UseComputersTimezoneForExecution);
