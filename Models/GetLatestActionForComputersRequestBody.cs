using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetLatestActionForComputersRequestBody(
    [property: JsonPropertyName("computerIds")]
    ICollection<int>? ComputerIds,
    [property: JsonPropertyName("dateUtc")]
    DateTimeOffset? DateUtc,
    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,
    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType);
