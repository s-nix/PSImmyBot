using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateGlobalTargetAssignmentPayload(
    [property: JsonPropertyName("desiredSoftwareState")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DesiredSoftwareState>))]
    DesiredSoftwareState DesiredSoftwareState,
    [property: JsonPropertyName("excluded")]
    bool Excluded,
    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,
    [property: JsonPropertyName("maintenanceTaskMode")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskMode>))]
    MaintenanceTaskMode MaintenanceTaskMode,
    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,
    [property: JsonPropertyName("onboardingOnly")]
    bool OnboardingOnly,
    [property: JsonPropertyName("softwareProviderType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareProviderType>))]
    SoftwareProviderType SoftwareProviderType,
    [property: JsonPropertyName("softwareSemanticVersion")]
    SemanticVersion SoftwareSemanticVersion,
    [property: JsonPropertyName("target")] string? Target,
    [property: JsonPropertyName("targetCategory")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetCategory>))]
    TargetCategory TargetCategory,
    [property: JsonPropertyName("targetEnforcement")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetEnforcement>))]
    TargetEnforcement TargetEnforcement,
    [property: JsonPropertyName("targetGroupFilter")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetGroupFilter>))]
    TargetGroupFilter TargetGroupFilter,
    [property: JsonPropertyName("targetType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetType>))]
    TargetType TargetType,
    [property: JsonPropertyName("taskParameterValues")]
    IDictionary<string, DeploymentParameterValue>? TaskParameterValues);
