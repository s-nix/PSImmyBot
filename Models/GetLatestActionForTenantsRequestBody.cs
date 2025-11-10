using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetLatestActionForTenantsRequestBody(
    [property: JsonPropertyName("dateUtc")]
    DateTimeOffset? DateUtc,
    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,
    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,
    [property: JsonPropertyName("tenantIds")]
    ICollection<int>? TenantIds);
