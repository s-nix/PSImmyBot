using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateLicenseRequestBody(
    [property: JsonPropertyName("licenseValue")]
    string? LicenseValue, [property: JsonPropertyName("name")] string? Name,
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
    int? TenantId);
