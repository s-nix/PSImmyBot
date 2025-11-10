using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record TargetAssignment {
    [JsonConstructor]
    [Obsolete]
    public TargetAssignment(bool @allowAccessToParentTenant, bool @autoApprove, ICollection<ChangeRequest>? @changeRequests, int? @createdBy, User @createdByUser, DateTimeOffset @createdDate, DatabaseType @databaseType, DesiredSoftwareState @desiredSoftwareState, bool @excluded, int @id, string? @integrationPrompt, string? @integrationTypeId, bool @isCore, License @license, int? @licenseId, string? @maintenanceIdentifier, MaintenanceSpecifier @maintenanceSpecifier, MaintenanceTaskMode @maintenanceTaskMode, ICollection<MaintenanceTaskParameterValue>? @maintenanceTaskParameterValues, MaintenanceType @maintenanceType, TargetAssignmentNotes @notes, bool @onboardingOnly, string? @parameterValueMigrationErrors, bool @propagateToChildTenants, Guid? @providerClientGroupType, Guid? @providerDeviceGroupType, ProviderLink @providerLink, int? @providerLinkId, int? @providerLinkIdForMaintenanceItem, int? @softwareId, SoftwareProviderType @softwareProviderType, SemanticVersion @softwareSemanticVersion, string? @softwareSemanticVersionString, SoftwareSpecifier @softwareSpecifier, int @softwareVersionId, int @sortOrder, string? @target, TargetCategory @targetCategory, TargetEnforcement @targetEnforcement, TargetGroupFilter @targetGroupFilter, string? @targetName, TargetType @targetType, IDictionary<string, DeploymentParameterValue>? @taskParameterValues, int? @tenantId, int? @updatedBy, User @updatedByUser, DateTimeOffset @updatedDate, TargetAssignmentVisibility @visibility) {
        CreatedDate = @createdDate;
        UpdatedDate = @updatedDate;
        CreatedBy = @createdBy;
        UpdatedBy = @updatedBy;
        Id = @id;
        DatabaseType = @databaseType;
        IsCore = @isCore;
        AutoApprove = @autoApprove;
        IntegrationTypeId = @integrationTypeId;
        IntegrationPrompt = @integrationPrompt;
        Excluded = @excluded;
        SortOrder = @sortOrder;
        MaintenanceIdentifier = @maintenanceIdentifier;
        MaintenanceType = @maintenanceType;
        OnboardingOnly = @onboardingOnly;
        TargetEnforcement = @targetEnforcement;
        TargetType = @targetType;
        TargetCategory = @targetCategory;
        TargetGroupFilter = @targetGroupFilter;
        Target = @target;
        TenantId = @tenantId;
        PropagateToChildTenants = @propagateToChildTenants;
        AllowAccessToParentTenant = @allowAccessToParentTenant;
        ProviderLinkId = @providerLinkId;
        ProviderDeviceGroupType = @providerDeviceGroupType;
        ProviderClientGroupType = @providerClientGroupType;
        ProviderLinkIdForMaintenanceItem = @providerLinkIdForMaintenanceItem;
        TargetName = @targetName;
        ProviderLink = @providerLink;
        Notes = @notes;
        Visibility = @visibility;
        SoftwareSemanticVersion = @softwareSemanticVersion;
        SoftwareSemanticVersionString = @softwareSemanticVersionString;
        DesiredSoftwareState = @desiredSoftwareState;
        SoftwareProviderType = @softwareProviderType;
        TaskParameterValues = @taskParameterValues;
        LicenseId = @licenseId;
        License = @license;
        MaintenanceTaskMode = @maintenanceTaskMode;
        MaintenanceTaskParameterValues = @maintenanceTaskParameterValues;
        ChangeRequests = @changeRequests;
        ParameterValueMigrationErrors = @parameterValueMigrationErrors;
        SoftwareSpecifier = @softwareSpecifier;
        MaintenanceSpecifier = @maintenanceSpecifier;
        CreatedByUser = @createdByUser;
        UpdatedByUser = @updatedByUser;
        SoftwareId = @softwareId;
        SoftwareVersionId = @softwareVersionId;
    }

    [JsonPropertyName("createdDate")]
    public DateTimeOffset CreatedDate { get; init; }

    [JsonPropertyName("updatedDate")]
    public DateTimeOffset UpdatedDate { get; init; }

    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; init; }

    [JsonPropertyName("updatedBy")]
    public int? UpdatedBy { get; init; }

    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("databaseType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType DatabaseType { get; init; }

    [JsonPropertyName("isCore")]
    public bool IsCore { get; init; }

    [JsonPropertyName("autoApprove")]
    public bool AutoApprove { get; init; }

    [JsonPropertyName("integrationTypeId")]
    public string? IntegrationTypeId { get; init; }

    [JsonPropertyName("integrationPrompt")]
    public string? IntegrationPrompt { get; init; }

    [JsonPropertyName("excluded")]
    public bool Excluded { get; init; }

    [JsonPropertyName("sortOrder")]
    public int SortOrder { get; init; }

    [JsonPropertyName("maintenanceIdentifier")]
    public string? MaintenanceIdentifier { get; init; }

    [JsonPropertyName("maintenanceType")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    public MaintenanceType MaintenanceType { get; init; }

    [JsonPropertyName("onboardingOnly")]
    [Obsolete]
    public bool OnboardingOnly { get; init; }

    [JsonPropertyName("targetEnforcement")]
    [JsonConverter(typeof(JsonStringEnumConverter<TargetEnforcement>))]
    public TargetEnforcement TargetEnforcement { get; init; }

    [JsonPropertyName("targetType")]
    [JsonConverter(typeof(JsonStringEnumConverter<TargetType>))]
    public TargetType TargetType { get; init; }

    [JsonPropertyName("targetCategory")]
    [JsonConverter(typeof(JsonStringEnumConverter<TargetCategory>))]
    public TargetCategory TargetCategory { get; init; }

    [JsonPropertyName("targetGroupFilter")]
    [JsonConverter(typeof(JsonStringEnumConverter<TargetGroupFilter>))]
    public TargetGroupFilter TargetGroupFilter { get; init; }

    [JsonPropertyName("target")]
    public string? Target { get; init; }

    [JsonPropertyName("tenantId")]
    public int? TenantId { get; init; }

    [JsonPropertyName("propagateToChildTenants")]
    public bool PropagateToChildTenants { get; init; }

    [JsonPropertyName("allowAccessToParentTenant")]
    public bool AllowAccessToParentTenant { get; init; }

    [JsonPropertyName("providerLinkId")]
    public int? ProviderLinkId { get; init; }

    [JsonPropertyName("providerDeviceGroupType")]
    public Guid? ProviderDeviceGroupType { get; init; }

    [JsonPropertyName("providerClientGroupType")]
    public Guid? ProviderClientGroupType { get; init; }

    [JsonPropertyName("providerLinkIdForMaintenanceItem")]
    public int? ProviderLinkIdForMaintenanceItem { get; init; }

    [JsonPropertyName("targetName")]
    public string? TargetName { get; init; }

    [JsonPropertyName("providerLink")]
    public ProviderLink ProviderLink { get; init; }

    [JsonPropertyName("notes")]
    public TargetAssignmentNotes Notes { get; init; }

    [JsonPropertyName("visibility")]
    public TargetAssignmentVisibility Visibility { get; init; }

    [JsonPropertyName("softwareSemanticVersion")]
    public SemanticVersion SoftwareSemanticVersion { get; init; }

    [JsonPropertyName("softwareSemanticVersionString")]
    public string? SoftwareSemanticVersionString { get; init; }

    [JsonPropertyName("desiredSoftwareState")]
    [JsonConverter(typeof(JsonStringEnumConverter<DesiredSoftwareState>))]
    public DesiredSoftwareState DesiredSoftwareState { get; init; }

    [JsonPropertyName("softwareProviderType")]
    [JsonConverter(typeof(JsonStringEnumConverter<SoftwareProviderType>))]
    public SoftwareProviderType SoftwareProviderType { get; init; }

    [JsonPropertyName("taskParameterValues")]
    public IDictionary<string, DeploymentParameterValue>? TaskParameterValues { get; init; }

    [JsonPropertyName("licenseId")]
    public int? LicenseId { get; init; }

    [JsonPropertyName("license")]
    public License License { get; init; }

    [JsonPropertyName("maintenanceTaskMode")]
    [JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskMode>))]
    public MaintenanceTaskMode MaintenanceTaskMode { get; init; }

    [JsonPropertyName("maintenanceTaskParameterValues")]
    [Obsolete]
    public ICollection<MaintenanceTaskParameterValue>? MaintenanceTaskParameterValues { get; init; }

    [JsonPropertyName("changeRequests")]
    public ICollection<ChangeRequest>? ChangeRequests { get; init; }

    [JsonPropertyName("parameterValueMigrationErrors")]
    public string? ParameterValueMigrationErrors { get; init; }

    [JsonPropertyName("softwareSpecifier")]
    public SoftwareSpecifier SoftwareSpecifier { get; init; }

    [JsonPropertyName("maintenanceSpecifier")]
    public MaintenanceSpecifier MaintenanceSpecifier { get; init; }

    [JsonPropertyName("createdByUser")]
    public User CreatedByUser { get; init; }

    [JsonPropertyName("updatedByUser")]
    public User UpdatedByUser { get; init; }

    [JsonPropertyName("softwareId")]
    [Obsolete]
    public int? SoftwareId { get; init; }

    [JsonPropertyName("softwareVersionId")]
    [Obsolete]
    public int SoftwareVersionId { get; init; }
}
