using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ActiveSession(
    [property: JsonPropertyName("maintenanceSession")]
    MaintenanceSession MaintenanceSession,
    [property: JsonPropertyName("maintenanceSessionId")]
    int MaintenanceSessionId,
    [property: JsonPropertyName("sessionStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SessionStatus>))]
    SessionStatus SessionStatus);

#pragma warning restore 649
