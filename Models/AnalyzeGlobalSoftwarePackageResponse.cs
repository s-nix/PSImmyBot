using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AnalyzeGlobalSoftwarePackageResponse(
    [property: JsonPropertyName("batchInstallScript")]
    IScriptDetailsBase BatchInstallScript,
    [property: JsonPropertyName("defaultPowershellUninstallScript")]
    IScriptDetailsBase DefaultPowershellUninstallScript,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("detectionScript")]
    IScriptDetailsBase DetectionScript,
    [property: JsonPropertyName("displayVersion")]
    string? DisplayVersion,
    [property: JsonPropertyName("extension")]
    string? Extension,
    [property: JsonPropertyName("fileName")]
    string? FileName,
    [property: JsonPropertyName("isExe")] bool IsExe,
    [property: JsonPropertyName("isMsi")] bool IsMsi,
    [property: JsonPropertyName("packageHash")]
    string? PackageHash,
    [property: JsonPropertyName("packageType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<PackageType>))]
    PackageType PackageType,
    [property: JsonPropertyName("powerShellInstallScript")]
    IScriptDetailsBase PowerShellInstallScript,
    [property: JsonPropertyName("powerShellUninstallScript")]
    IScriptDetailsBase PowerShellUninstallScript,
    [property: JsonPropertyName("productCode")]
    Guid? ProductCode,
    [property: JsonPropertyName("softwareTableName")]
    string? SoftwareTableName,
    [property: JsonPropertyName("upgradeCode")]
    Guid? UpgradeCode);
