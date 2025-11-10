using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceItemOrder([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("location")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceItemOrderLocation>))]
    MaintenanceItemOrderLocation Location,
    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,
    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,
    [property: JsonPropertyName("sortOrder")]
    double SortOrder);
