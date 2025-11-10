using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record GlobalSoftware {
    [JsonConstructor]
    [Obsolete]
    public GlobalSoftware(Guid? @agentIntegrationTypeId, string? @chocoProviderSoftwareId, int? @createdBy, DateTimeOffset @createdDate, ICollection<AuditPropertyChange>? @customAuditProperties, DetectionMethod @detectionMethod, Script @detectionScript, int? @detectionScriptId, DatabaseType @detectionScriptType, Script @downloadInstallerScript, int? @downloadInstallerScriptId, DatabaseType @downloadInstallerScriptType, Script @dynamicVersionsScript, int? @dynamicVersionsScriptId, DatabaseType @dynamicVersionsScriptType, bool @hidden, int @id, string? @identifier, int @installOrder, Script @installScript, int? @installScriptId, DatabaseType @installScriptType, string? @licenseDescription, SoftwareLicenseRequirement @licenseRequirement, LicenseType @licenseType, MaintenanceSpecifier @maintenanceSpecifier, MaintenanceTask @maintenanceTask, int? @maintenanceTaskId, DatabaseType @maintenanceTaskType, MaintenanceType @maintenanceType, string? @name, string? @niniteProviderSoftwareId, string? @notes, Script @postInstallScript, int? @postInstallScriptId, DatabaseType @postInstallScriptType, Script @postUninstallScript, int? @postUninstallScriptId, DatabaseType @postUninstallScriptType, bool @rebootNeeded, bool @recommended, Guid @relativeCacheSourcePath, Script @repairScript, int? @repairScriptId, DatabaseType @repairScriptType, RepairActionType @repairType, Media @softwareIcon, int? @softwareIconMediaId, ICollection<SoftwarePrerequisite>? @softwarePrerequisites, string? @softwareTableName, SoftwareTableNameSearchMode @softwareTableNameSearchMode, SoftwareType @softwareType, ICollection<GlobalSoftwareVersion>? @softwareVersions, string? @testFailedError, bool @testRequired, Script @testScript, int? @testScriptId, DatabaseType @testScriptType, Script @uninstallScript, int? @uninstallScriptId, DatabaseType @uninstallScriptType, int? @updatedBy, DateTimeOffset @updatedDate, string? @upgradeCode, Script @upgradeScript, int? @upgradeScriptId, DatabaseType @upgradeScriptType, UpdateActionType @upgradeStrategy, bool @useDynamicVersions, bool @useSoftwareTableDetection) {
        CreatedDate = @createdDate;
        UpdatedDate = @updatedDate;
        CreatedBy = @createdBy;
        UpdatedBy = @updatedBy;
        Name = @name;
        LicenseRequirement = @licenseRequirement;
        InstallOrder = @installOrder;
        Hidden = @hidden;
        SoftwareTableName = @softwareTableName;
        DetectionMethod = @detectionMethod;
        SoftwareTableNameSearchMode = @softwareTableNameSearchMode;
        AgentIntegrationTypeId = @agentIntegrationTypeId;
        DetectionScript = @detectionScript;
        DetectionScriptId = @detectionScriptId;
        DetectionScriptType = @detectionScriptType;
        DownloadInstallerScript = @downloadInstallerScript;
        DownloadInstallerScriptId = @downloadInstallerScriptId;
        DownloadInstallerScriptType = @downloadInstallerScriptType;
        UpgradeCode = @upgradeCode;
        MaintenanceTask = @maintenanceTask;
        MaintenanceTaskId = @maintenanceTaskId;
        Notes = @notes;
        RebootNeeded = @rebootNeeded;
        RepairType = @repairType;
        RepairScript = @repairScript;
        RepairScriptId = @repairScriptId;
        RepairScriptType = @repairScriptType;
        SoftwareIconMediaId = @softwareIconMediaId;
        Recommended = @recommended;
        ChocoProviderSoftwareId = @chocoProviderSoftwareId;
        NiniteProviderSoftwareId = @niniteProviderSoftwareId;
        MaintenanceType = @maintenanceType;
        UseSoftwareTableDetection = @useSoftwareTableDetection;
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
        TestRequired = @testRequired;
        TestFailedError = @testFailedError;
        UpgradeStrategy = @upgradeStrategy;
        LicenseType = @licenseType;
        LicenseDescription = @licenseDescription;
        UseDynamicVersions = @useDynamicVersions;
        DynamicVersionsScriptId = @dynamicVersionsScriptId;
        DynamicVersionsScriptType = @dynamicVersionsScriptType;
        DynamicVersionsScript = @dynamicVersionsScript;
        RelativeCacheSourcePath = @relativeCacheSourcePath;
        MaintenanceSpecifier = @maintenanceSpecifier;
        Id = @id;
        SoftwareIcon = @softwareIcon;
        SoftwareVersions = @softwareVersions;
        SoftwareType = @softwareType;
        Identifier = @identifier;
        MaintenanceTaskType = @maintenanceTaskType;
        SoftwarePrerequisites = @softwarePrerequisites;
        CustomAuditProperties = @customAuditProperties;
    }

    [JsonPropertyName("createdDate")]
    public DateTimeOffset CreatedDate { get; init; }

    [JsonPropertyName("updatedDate")]
    public DateTimeOffset UpdatedDate { get; init; }

    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; init; }

    [JsonPropertyName("updatedBy")]
    public int? UpdatedBy { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("licenseRequirement")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareLicenseRequirement>))]
    public SoftwareLicenseRequirement LicenseRequirement { get; init; }

    [JsonPropertyName("installOrder")]
    public int InstallOrder { get; init; }

    [JsonPropertyName("hidden")]
    public bool Hidden { get; init; }

    [JsonPropertyName("softwareTableName")]
    public string? SoftwareTableName { get; init; }

    [JsonPropertyName("detectionMethod")]
    [JsonConverter(typeof(JsonStringEnumConverter<DetectionMethod>))]
    public DetectionMethod DetectionMethod { get; init; }

    [JsonPropertyName("softwareTableNameSearchMode")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareTableNameSearchMode>))]
    public SoftwareTableNameSearchMode SoftwareTableNameSearchMode { get; init; }

    [JsonPropertyName("agentIntegrationTypeId")]
    public Guid? AgentIntegrationTypeId { get; init; }

    [JsonPropertyName("detectionScript")]
    public Script DetectionScript { get; init; }

    [JsonPropertyName("detectionScriptId")]
    public int? DetectionScriptId { get; init; }

    [JsonPropertyName("detectionScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType DetectionScriptType { get; init; }

    [JsonPropertyName("downloadInstallerScript")]
    public Script DownloadInstallerScript { get; init; }

    [JsonPropertyName("downloadInstallerScriptId")]
    public int? DownloadInstallerScriptId { get; init; }

    [JsonPropertyName("downloadInstallerScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType DownloadInstallerScriptType { get; init; }

    [JsonPropertyName("upgradeCode")]
    public string? UpgradeCode { get; init; }

    [JsonPropertyName("maintenanceTask")]
    public MaintenanceTask MaintenanceTask { get; init; }

    [JsonPropertyName("maintenanceTaskId")]
    public int? MaintenanceTaskId { get; init; }

    [JsonPropertyName("notes")]
    public string? Notes { get; init; }

    [JsonPropertyName("rebootNeeded")]
    public bool RebootNeeded { get; init; }

    [JsonPropertyName("repairType")]
    [JsonConverter(typeof(JsonStringEnumConverter<RepairActionType>))]
    public RepairActionType RepairType { get; init; }

    [JsonPropertyName("repairScript")]
    public Script RepairScript { get; init; }

    [JsonPropertyName("repairScriptId")]
    public int? RepairScriptId { get; init; }

    [JsonPropertyName("repairScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType RepairScriptType { get; init; }

    [JsonPropertyName("softwareIconMediaId")]
    public int? SoftwareIconMediaId { get; init; }

    [JsonPropertyName("recommended")]
    public bool Recommended { get; init; }

    [JsonPropertyName("chocoProviderSoftwareId")]
    public string? ChocoProviderSoftwareId { get; init; }

    [JsonPropertyName("niniteProviderSoftwareId")]
    public string? NiniteProviderSoftwareId { get; init; }

    [JsonPropertyName("maintenanceType")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    public MaintenanceType MaintenanceType { get; init; }

    [JsonPropertyName("useSoftwareTableDetection")]
    [Obsolete]
    public bool UseSoftwareTableDetection { get; init; }

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

    [JsonPropertyName("testRequired")]
    public bool TestRequired { get; init; }

    [JsonPropertyName("testFailedError")]
    public string? TestFailedError { get; init; }

    [JsonPropertyName("upgradeStrategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<UpdateActionType>))]
    public UpdateActionType UpgradeStrategy { get; init; }

    [JsonPropertyName("licenseType")]
    [JsonConverter(typeof(JsonStringEnumConverter<LicenseType>))]
    public LicenseType LicenseType { get; init; }

    [JsonPropertyName("licenseDescription")]
    public string? LicenseDescription { get; init; }

    [JsonPropertyName("useDynamicVersions")]
    public bool UseDynamicVersions { get; init; }

    [JsonPropertyName("dynamicVersionsScriptId")]
    public int? DynamicVersionsScriptId { get; init; }

    [JsonPropertyName("dynamicVersionsScriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType DynamicVersionsScriptType { get; init; }

    [JsonPropertyName("dynamicVersionsScript")]
    public Script DynamicVersionsScript { get; init; }

    [JsonPropertyName("relativeCacheSourcePath")]
    public Guid RelativeCacheSourcePath { get; init; }

    [JsonPropertyName("maintenanceSpecifier")]
    public MaintenanceSpecifier MaintenanceSpecifier { get; init; }

    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("softwareIcon")]
    public Media SoftwareIcon { get; init; }

    [JsonPropertyName("softwareVersions")]
    public ICollection<GlobalSoftwareVersion>? SoftwareVersions { get; init; }

    [JsonPropertyName("softwareType")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    public SoftwareType SoftwareType { get; init; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; init; }

    [JsonPropertyName("maintenanceTaskType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType MaintenanceTaskType { get; init; }

    [JsonPropertyName("softwarePrerequisites")]
    public ICollection<SoftwarePrerequisite>? SoftwarePrerequisites { get; init; }

    [JsonPropertyName("customAuditProperties")]
    public ICollection<AuditPropertyChange>? CustomAuditProperties { get; init; }
}
