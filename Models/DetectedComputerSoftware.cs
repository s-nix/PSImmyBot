using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DetectedComputerSoftware(
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("context")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareRegistryContext>))]
    SoftwareRegistryContext Context,
    [property: JsonPropertyName("detectedAt")]
    DateTimeOffset DetectedAt,
    [property: JsonPropertyName("displayIcon")]
    string? DisplayIcon,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("displayVersion")]
    string? DisplayVersion,
    [property: JsonPropertyName("globalSoftwareId")]
    int? GlobalSoftwareId,
    [property: JsonPropertyName("globalSoftwareName")]
    string? GlobalSoftwareName,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("installDate")]
    DateTimeOffset? InstallDate,
    [property: JsonPropertyName("installLocation")]
    string? InstallLocation,
    [property: JsonPropertyName("originalKey")]
    string? OriginalKey,
    [property: JsonPropertyName("platform")]
    string? Platform,
    [property: JsonPropertyName("primaryPerson")]
    Person PrimaryPerson,
    [property: JsonPropertyName("primaryPersonId")]
    int? PrimaryPersonId,
    [property: JsonPropertyName("productCode")]
    Guid? ProductCode,
    [property: JsonPropertyName("quietUninstallString")]
    string? QuietUninstallString,
    [property: JsonPropertyName("registryPath")]
    string? RegistryPath,
    [property: JsonPropertyName("systemComponent")]
    int? SystemComponent,
    [property: JsonPropertyName("tenant")] Tenant Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("uninstallString")]
    string? UninstallString,
    [property: JsonPropertyName("upgradeCode")]
    Guid? UpgradeCode,
    [property: JsonPropertyName("userName")]
    string? UserName,
    [property: JsonPropertyName("userSid")]
    string? UserSid);
