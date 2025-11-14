using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetTargetAssignmentTypeResponse(
    [property: JsonPropertyName("allowAccessToParentTenant")]
    bool AllowAccessToParentTenant,
    [property: JsonPropertyName("desiredSoftwareState")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DesiredSoftwareState>))]
    DesiredSoftwareState DesiredSoftwareState,
    [property: JsonPropertyName("maintenanceTaskMode")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskMode>))]
    MaintenanceTaskMode MaintenanceTaskMode,
    [property: JsonPropertyName("propagateToChildTenants")]
    bool PropagateToChildTenants,
    [property: JsonPropertyName("target")] string? Target,
    [property: JsonPropertyName("targetEnforcement")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetEnforcement>))]
    TargetEnforcement TargetEnforcement,
    [property: JsonPropertyName("targetType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetType>))]
    TargetType TargetType,
    [property: JsonPropertyName("tenantId")]
    int? TenantId);
