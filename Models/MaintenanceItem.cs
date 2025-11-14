using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceItem(
    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,
    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,
    [property: JsonPropertyName("providerLinkIdForMaintenanceItem")]
    int? ProviderLinkIdForMaintenanceItem);
