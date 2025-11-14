using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetLicenseResponse(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("licenseValue")]
    string? LicenseValue,
    [property: JsonPropertyName("name")] string? Name,
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
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("updatedBy")]
    string? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
