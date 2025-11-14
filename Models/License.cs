using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record License(
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("licenseValue")]
    string? LicenseValue,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("restrictToMajorVersion")]
    bool RestrictToMajorVersion,
    [property: JsonPropertyName("semanticVersion")]
    SemanticVersion SemanticVersion,
    [property: JsonPropertyName("softwareIdentifier")]
    string? SoftwareIdentifier,
    [property: JsonPropertyName("softwareName")]
    string? SoftwareName,
    [property: JsonPropertyName("softwareType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    SoftwareType SoftwareType,
    [property: JsonPropertyName("targetAssignments")]
    ICollection<TargetAssignment>? TargetAssignments,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
