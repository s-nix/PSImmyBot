using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateMaintenanceItemOrderPayload([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("location")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceItemOrderLocation>))]
    MaintenanceItemOrderLocation Location,
    [property: JsonPropertyName("toIndex")]
    int? ToIndex);
