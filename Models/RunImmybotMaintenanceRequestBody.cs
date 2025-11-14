using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RunImmybotMaintenanceRequestBody(
    [property: JsonPropertyName("desiredSoftwareState")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DesiredSoftwareState>))]
    DesiredSoftwareState DesiredSoftwareState,
    [property: JsonPropertyName("maintenanceIdentifier")]
    string? MaintenanceIdentifier,
    [property: JsonPropertyName("maintenanceTaskMode")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskMode>))]
    MaintenanceTaskMode MaintenanceTaskMode,
    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,
    [property: JsonPropertyName("providerLinkIdForMaintenanceItem")]
    int? ProviderLinkIdForMaintenanceItem,
    [property: JsonPropertyName("repair")] bool Repair,
    [property: JsonPropertyName("semanticVersion")]
    SemanticVersion SemanticVersion,
    [property: JsonPropertyName("semanticVersionNormalized")]
    string? SemanticVersionNormalized,
    [property: JsonPropertyName("softwareProviderType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareProviderType>))]
    SoftwareProviderType SoftwareProviderType,
    [property: JsonPropertyName("softwareType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    SoftwareType SoftwareType,
    [property: JsonPropertyName("taskParameterValues")]
    IDictionary<string, DeploymentParameterValue>? TaskParameterValues);
