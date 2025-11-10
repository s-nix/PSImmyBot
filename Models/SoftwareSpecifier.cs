using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SoftwareSpecifier(
    [property: JsonPropertyName("maintenanceSpecifier")]
    MaintenanceSpecifier MaintenanceSpecifier,
    [property: JsonPropertyName("softwareIdentifier")]
    string? SoftwareIdentifier,
    [property: JsonPropertyName("softwareType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    SoftwareType SoftwareType);
