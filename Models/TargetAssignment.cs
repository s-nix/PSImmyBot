using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TargetAssignment(
    [property: JsonPropertyName("allowAccessToParentTenant")]
    bool AllowAccessToParentTenant,

    [property: JsonPropertyName("autoApprove")]
    bool AutoApprove,

    [property: JsonPropertyName("changeRequests")]
    ICollection<ChangeRequest>? ChangeRequests,

    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,

    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,

    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,

    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,

    [property: JsonPropertyName("desiredSoftwareState")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DesiredSoftwareState>))]
    DesiredSoftwareState DesiredSoftwareState,

    [property: JsonPropertyName("excluded")]
    bool Excluded,

    [property: JsonPropertyName("id")]
    int Id,

    [property: JsonPropertyName("integrationPrompt")]
    string? IntegrationPrompt,

    [property: JsonPropertyName("integrationTypeId")]
    string? IntegrationTypeId,

    [property: JsonPropertyName("isCore")]
    bool IsCore,

    [property: JsonPropertyName("license")]
    License License,

    [property: JsonPropertyName("licenseId")]
    int? LicenseId,

    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,

    [property: JsonPropertyName("maintenanceSpecifier")]
    MaintenanceSpecifier MaintenanceSpecifier,

    [property: JsonPropertyName("maintenanceTaskMode")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskMode>))]
    MaintenanceTaskMode MaintenanceTaskMode,

    [property: JsonPropertyName("maintenanceTaskParameterValues")]
    [property: Obsolete]
    ICollection<MaintenanceTaskParameterValue>? MaintenanceTaskParameterValues,

    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,

    [property: JsonPropertyName("notes")]
    TargetAssignmentNotes Notes,

    [property: JsonPropertyName("onboardingOnly")]
    [property: Obsolete]
    bool OnboardingOnly,

    [property: JsonPropertyName("parameterValueMigrationErrors")]
    string? ParameterValueMigrationErrors,

    [property: JsonPropertyName("propagateToChildTenants")]
    bool PropagateToChildTenants,

    [property: JsonPropertyName("providerClientGroupType")]
    Guid? ProviderClientGroupType,

    [property: JsonPropertyName("providerDeviceGroupType")]
    Guid? ProviderDeviceGroupType,

    [property: JsonPropertyName("providerLink")]
    ProviderLink ProviderLink,

    [property: JsonPropertyName("providerLinkId")]
    int? ProviderLinkId,

    [property: JsonPropertyName("providerLinkIdForMaintenanceItem")]
    int? ProviderLinkIdForMaintenanceItem,

    [property: JsonPropertyName("softwareId")]
    [property: Obsolete]
    int? SoftwareId,

    [property: JsonPropertyName("softwareProviderType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareProviderType>))]
    SoftwareProviderType SoftwareProviderType,

    [property: JsonPropertyName("softwareSemanticVersion")]
    SemanticVersion SoftwareSemanticVersion,

    [property: JsonPropertyName("softwareSemanticVersionString")]
    string? SoftwareSemanticVersionString,

    [property: JsonPropertyName("softwareSpecifier")]
    SoftwareSpecifier SoftwareSpecifier,

    [property: JsonPropertyName("softwareVersionId")]
    [property: Obsolete]
    int SoftwareVersionId,

    [property: JsonPropertyName("sortOrder")]
    int SortOrder,

    [property: JsonPropertyName("target")]
    string? Target,

    [property: JsonPropertyName("targetCategory")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetCategory>))]
    TargetCategory TargetCategory,

    [property: JsonPropertyName("targetEnforcement")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetEnforcement>))]
    TargetEnforcement TargetEnforcement,

    [property: JsonPropertyName("targetGroupFilter")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetGroupFilter>))]
    TargetGroupFilter TargetGroupFilter,

    [property: JsonPropertyName("targetName")]
    string? TargetName,

    [property: JsonPropertyName("targetType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetType>))]
    TargetType TargetType,

    [property: JsonPropertyName("taskParameterValues")]
    IDictionary<string, DeploymentParameterValue>? TaskParameterValues,

    [property: JsonPropertyName("tenantId")]
    int? TenantId,

    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,

    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,

    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,

    [property: JsonPropertyName("visibility")]
    TargetAssignmentVisibility Visibility
);
