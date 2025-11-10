using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Media(
    [property: JsonPropertyName("blobReference")]
    string? BlobReference,
    [property: JsonPropertyName("category")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MediaCategory>))]
    MediaCategory Category,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("dynamicIntegrationTypes")]
    ICollection<DynamicIntegrationType>? DynamicIntegrationTypes,
    [property: JsonPropertyName("fileName")]
    string? FileName,
    [property: JsonPropertyName("globalSoftware")]
    ICollection<GlobalSoftware>? GlobalSoftware,
    [property: JsonPropertyName("iconForMaintenanceTasks")]
    ICollection<MaintenanceTask>? IconForMaintenanceTasks,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("localSoftware")]
    ICollection<LocalSoftware>? LocalSoftware,
    [property: JsonPropertyName("mimeType")]
    string? MimeType,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("packageHash")]
    string? PackageHash,
    [property: JsonPropertyName("relativeCacheSourcePath")]
    string? RelativeCacheSourcePath,
    [property: JsonPropertyName("tenantRelationships")]
    ICollection<TenantMedia>? TenantRelationships,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
