using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LocalSoftwareVersion(
    [property: JsonPropertyName("architecture")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Architecture>))]
    Architecture Architecture,

    [property: JsonPropertyName("blobName")]
    string? BlobName,

    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,

    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,

    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,

    [property: JsonPropertyName("dependsOnSemanticVersion")]
    SemanticVersion DependsOnSemanticVersion,

    [property: JsonPropertyName("deprecatedIdField")]
    [property: Obsolete]
    int? DeprecatedIdField,

    [property: JsonPropertyName("displayName")]
    string? DisplayName,

    [property: JsonPropertyName("displayVersion")]
    string? DisplayVersion,

    [property: JsonPropertyName("installerFile")]
    string? InstallerFile,

    [property: JsonPropertyName("installerType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareVersionInstallerType>))]
    SoftwareVersionInstallerType InstallerType,

    [property: JsonPropertyName("installScript")]
    Script InstallScript,

    [property: JsonPropertyName("installScriptId")]
    int? InstallScriptId,

    [property: JsonPropertyName("installScriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType InstallScriptType,

    [property: JsonPropertyName("lastResult")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionResult>))]
    MaintenanceActionResult LastResult,

    [property: JsonPropertyName("licenseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<LicenseType>))]
    LicenseType LicenseType,

    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,

    [property: JsonPropertyName("notes")]
    string? Notes,

    [property: JsonPropertyName("numActionFailures")]
    int NumActionFailures,

    [property: JsonPropertyName("numActionSuccesses")]
    int NumActionSuccesses,

    [property: JsonPropertyName("packageHash")]
    string? PackageHash,

    [property: JsonPropertyName("packageType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<PackageType>))]
    PackageType PackageType,

    [property: JsonPropertyName("postInstallScript")]
    Script PostInstallScript,

    [property: JsonPropertyName("postInstallScriptId")]
    int? PostInstallScriptId,

    [property: JsonPropertyName("postInstallScriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType PostInstallScriptType,

    [property: JsonPropertyName("postUninstallScript")]
    Script PostUninstallScript,

    [property: JsonPropertyName("postUninstallScriptId")]
    int? PostUninstallScriptId,

    [property: JsonPropertyName("postUninstallScriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType PostUninstallScriptType,

    [property: JsonPropertyName("productCode")]
    string? ProductCode,

    [property: JsonPropertyName("relativeCacheSourcePath")]
    string? RelativeCacheSourcePath,

    [property: JsonPropertyName("semanticVersion")]
    [property: System.ComponentModel.DataAnnotations.Required]
    SemanticVersion SemanticVersion,

    [property: JsonPropertyName("semanticVersionString")]
    string? SemanticVersionString,

    [property: JsonPropertyName("software")]
    LocalSoftware Software,

    [property: JsonPropertyName("softwareId")]
    int SoftwareId,

    [property: JsonPropertyName("softwareIdentifier")]
    string? SoftwareIdentifier,

    [property: JsonPropertyName("softwareType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    SoftwareType SoftwareType,

    [property: JsonPropertyName("testFailedError")]
    string? TestFailedError,

    [property: JsonPropertyName("testRequired")]
    bool TestRequired,

    [property: JsonPropertyName("testScript")]
    Script TestScript,

    [property: JsonPropertyName("testScriptId")]
    int? TestScriptId,

    [property: JsonPropertyName("testScriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType TestScriptType,

    [property: JsonPropertyName("uninstallScript")]
    Script UninstallScript,

    [property: JsonPropertyName("uninstallScriptId")]
    int? UninstallScriptId,

    [property: JsonPropertyName("uninstallScriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType UninstallScriptType,

    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,

    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,

    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,

    [property: JsonPropertyName("upgradeScript")]
    Script UpgradeScript,

    [property: JsonPropertyName("upgradeScriptId")]
    int? UpgradeScriptId,

    [property: JsonPropertyName("upgradeScriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType UpgradeScriptType,

    [property: JsonPropertyName("upgradeStrategy")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<UpdateActionType>))]
    UpdateActionType UpgradeStrategy,

    [property: JsonPropertyName("url")]
    string? Url
);
