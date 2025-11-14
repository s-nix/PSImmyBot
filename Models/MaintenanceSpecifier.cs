using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceSpecifier(
    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,
    [property: JsonPropertyName("maintenanceName")]
    string? MaintenanceName,
    [property: JsonPropertyName("maintenanceType")]
    [property: System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType);
