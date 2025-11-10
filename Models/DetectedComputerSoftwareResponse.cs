using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DetectedComputerSoftwareResponse(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("detectedAt")]
    DateTimeOffset DetectedAt,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("installDate")]
    DateTimeOffset? InstallDate,
    [property: JsonPropertyName("installLocation")]
    string? InstallLocation,
    [property: JsonPropertyName("personEmail")]
    string? PersonEmail,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("personName")]
    string? PersonName,
    [property: JsonPropertyName("platform")]
    string? Platform,
    [property: JsonPropertyName("productCode")]
    Guid? ProductCode,
    [property: JsonPropertyName("quietUninstallString")]
    string? QuietUninstallString,
    [property: JsonPropertyName("registryPath")]
    string? RegistryPath,
    [property: JsonPropertyName("softwareId")]
    int? SoftwareId,
    [property: JsonPropertyName("softwareName")]
    string? SoftwareName,
    [property: JsonPropertyName("systemComponent")]
    int? SystemComponent,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("uninstallString")]
    string? UninstallString,
    [property: JsonPropertyName("upgradeCode")]
    Guid? UpgradeCode,
    [property: JsonPropertyName("version")]
    string? Version);
