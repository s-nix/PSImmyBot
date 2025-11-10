using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record LocalSoftwareVersion {
    [JsonConstructor]
    [Obsolete]
    public LocalSoftwareVersion(Architecture @architecture, string? @blobName, int? @createdBy, User @createdByUser, DateTimeOffset @createdDate, SemanticVersion @dependsOnSemanticVersion, int? @deprecatedIdField, string? @displayName, string? @displayVersion, string? @installerFile, SoftwareVersionInstallerType @installerType, Script @installScript, int? @installScriptId, DatabaseType @installScriptType, MaintenanceActionResult @lastResult, LicenseType @licenseType, MaintenanceType @maintenanceType, string? @notes, int @numActionFailures, int @numActionSuccesses, string? @packageHash, PackageType @packageType, Script @postInstallScript, int? @postInstallScriptId, DatabaseType @postInstallScriptType, Script @postUninstallScript, int? @postUninstallScriptId, DatabaseType @postUninstallScriptType, string? @productCode, string? @relativeCacheSourcePath, SemanticVersion @semanticVersion, string? @semanticVersionString, LocalSoftware @software, int @softwareId, string? @softwareIdentifier, SoftwareType @softwareType, string? @testFailedError, bool @testRequired, Script @testScript, int? @testScriptId, DatabaseType @testScriptType, Script @uninstallScript, int? @uninstallScriptId, DatabaseType @uninstallScriptType, int? @updatedBy, User @updatedByUser, DateTimeOffset @updatedDate, Script @upgradeScript, int? @upgradeScriptId, DatabaseType @upgradeScriptType, UpdateActionType @upgradeStrategy, string? @url) {
        CreatedDate = @createdDate;
        UpdatedDate = @updatedDate;
        CreatedBy = @createdBy;
        UpdatedBy = @updatedBy;
        DisplayName = @displayName;
        DisplayVersion = @displayVersion;
        SemanticVersion = @semanticVersion;
        SemanticVersionString = @semanticVersionString;
        TestRequired = @testRequired;
        Url = @url;
        BlobName = @blobName;
        RelativeCacheSourcePath = @relativeCacheSourcePath;
        InstallerFile = @installerFile;
        TestFailedError = @testFailedError;
        PackageHash = @packageHash;
        ProductCode = @productCode;
        UpgradeStrategy = @upgradeStrategy;
        PackageType = @packageType;
        InstallerType = @installerType;
        MaintenanceType = @maintenanceType;
        NumActionSuccesses = @numActionSuccesses;
        NumActionFailures = @numActionFailures;
        LastResult = @lastResult;
        Notes = @notes;
        InstallScriptId = @installScriptId;
        InstallScriptType = @installScriptType;
        InstallScript = @installScript;
        TestScriptId = @testScriptId;
        TestScriptType = @testScriptType;
        TestScript = @testScript;
        UpgradeScriptId = @upgradeScriptId;
        UpgradeScriptType = @upgradeScriptType;
        UpgradeScript = @upgradeScript;
        UninstallScriptId = @uninstallScriptId;
        UninstallScriptType = @uninstallScriptType;
        UninstallScript = @uninstallScript;
        PostInstallScriptId = @postInstallScriptId;
        PostInstallScriptType = @postInstallScriptType;
        PostInstallScript = @postInstallScript;
        PostUninstallScriptId = @postUninstallScriptId;
        PostUninstallScriptType = @postUninstallScriptType;
        PostUninstallScript = @postUninstallScript;
        LicenseType = @licenseType;
        Architecture = @architecture;
        DependsOnSemanticVersion = @dependsOnSemanticVersion;
        DeprecatedIdField = @deprecatedIdField;
        SoftwareId = @softwareId;
        Software = @software;
        SoftwareType = @softwareType;
        SoftwareIdentifier = @softwareIdentifier;
        CreatedByUser = @createdByUser;
        UpdatedByUser = @updatedByUser;
    }

    [JsonPropertyName("createdDate")]
    public DateTimeOffset CreatedDate { get; init; }

    [JsonPropertyName("updatedDate")]
    public DateTimeOffset UpdatedDate { get; init; }

    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; init; }

    [JsonPropertyName("updatedBy")]
    public int? UpdatedBy { get; init; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("displayVersion")]
    public string? DisplayVersion { get; init; }

    [JsonPropertyName("semanticVersion")]
    [System.ComponentModel.DataAnnotations.Required]
    public SemanticVersion SemanticVersion { get; init; }

    [JsonPropertyName("semanticVersionString")]
    public string? SemanticVersionString { get; init; }

    [JsonPropertyName("testRequired")]
    public bool TestRequired { get; init; }

    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonPropertyName("blobName")]
    public string? BlobName { get; init; }

    [JsonPropertyName("relativeCacheSourcePath")]
    public string? RelativeCacheSourcePath { get; init; }

    [JsonPropertyName("installerFile")]
    public string? InstallerFile { get; init; }

    [JsonPropertyName("testFailedError")]
    public string? TestFailedError { get; init; }

    [JsonPropertyName("packageHash")]
    public string? PackageHash { get; init; }

    [JsonPropertyName("productCode")]
    public string? ProductCode { get; init; }

    [JsonPropertyName("upgradeStrategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<UpdateActionType>))]
    public UpdateActionType UpgradeStrategy { get; init; }

    [JsonPropertyName("packageType")]
    [JsonConverter(typeof(JsonStringEnumConverter<PackageType>))]
    public PackageType PackageType { get; init; }

    [JsonPropertyName("installerType")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareVersionInstallerType>))]
    public SoftwareVersionInstallerType InstallerType { get; init; }

    [JsonPropertyName("maintenanceType")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    public MaintenanceType MaintenanceType { get; init; }

    [JsonPropertyName("numActionSuccesses")]
    public int NumActionSuccesses { get; init; }

    [JsonPropertyName("numActionFailures")]
    public int NumActionFailures { get; init; }

    [JsonPropertyName("lastResult")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceActionResult>))]
    public MaintenanceActionResult LastResult { get; init; }

    [JsonPropertyName("notes")]
    public string? Notes { get; init; }

    [JsonPropertyName("installScriptId")]
    public int? InstallScriptId { get; init; }

    [JsonPropertyName("installScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType InstallScriptType { get; init; }

    [JsonPropertyName("installScript")]
    public Script InstallScript { get; init; }

    [JsonPropertyName("testScriptId")]
    public int? TestScriptId { get; init; }

    [JsonPropertyName("testScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType TestScriptType { get; init; }

    [JsonPropertyName("testScript")]
    public Script TestScript { get; init; }

    [JsonPropertyName("upgradeScriptId")]
    public int? UpgradeScriptId { get; init; }

    [JsonPropertyName("upgradeScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType UpgradeScriptType { get; init; }

    [JsonPropertyName("upgradeScript")]
    public Script UpgradeScript { get; init; }

    [JsonPropertyName("uninstallScriptId")]
    public int? UninstallScriptId { get; init; }

    [JsonPropertyName("uninstallScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType UninstallScriptType { get; init; }

    [JsonPropertyName("uninstallScript")]
    public Script UninstallScript { get; init; }

    [JsonPropertyName("postInstallScriptId")]
    public int? PostInstallScriptId { get; init; }

    [JsonPropertyName("postInstallScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType PostInstallScriptType { get; init; }

    [JsonPropertyName("postInstallScript")]
    public Script PostInstallScript { get; init; }

    [JsonPropertyName("postUninstallScriptId")]
    public int? PostUninstallScriptId { get; init; }

    [JsonPropertyName("postUninstallScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType PostUninstallScriptType { get; init; }

    [JsonPropertyName("postUninstallScript")]
    public Script PostUninstallScript { get; init; }

    [JsonPropertyName("licenseType")]
    [JsonConverter(typeof(JsonStringEnumConverter<LicenseType>))]
    public LicenseType LicenseType { get; init; }

    [JsonPropertyName("architecture")]
    [JsonConverter(typeof(JsonStringEnumConverter<Architecture>))]
    public Architecture Architecture { get; init; }

    [JsonPropertyName("dependsOnSemanticVersion")]
    public SemanticVersion DependsOnSemanticVersion { get; init; }

    [JsonPropertyName("deprecatedIdField")]
    [Obsolete]
    public int? DeprecatedIdField { get; init; }

    [JsonPropertyName("softwareId")]
    public int SoftwareId { get; init; }

    [JsonPropertyName("software")]
    public LocalSoftware Software { get; init; }

    [JsonPropertyName("softwareType")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    public SoftwareType SoftwareType { get; init; }

    [JsonPropertyName("softwareIdentifier")]
    public string? SoftwareIdentifier { get; init; }

    [JsonPropertyName("createdByUser")]
    public User CreatedByUser { get; init; }

    [JsonPropertyName("updatedByUser")]
    public User UpdatedByUser { get; init; }
}
