using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MigrationPreviewResponse(
    [property: JsonPropertyName("maintenanceTasks")]
    ICollection<MigratorDataDto>? MaintenanceTasks,
    [property: JsonPropertyName("scripts")]
    ICollection<MigratorDataDto>? Scripts,
    [property: JsonPropertyName("software")]
    ICollection<MigratorDataDto>? Software,
    [property: JsonPropertyName("softwareHasLocalPrerequisites")]
    bool SoftwareHasLocalPrerequisites,
    [property: JsonPropertyName("softwareVersions")]
    ICollection<MigratorDataDto>? SoftwareVersions);
