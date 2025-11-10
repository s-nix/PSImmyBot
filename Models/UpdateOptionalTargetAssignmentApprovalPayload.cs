using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateOptionalTargetAssignmentApprovalPayload(
    [property: JsonPropertyName("approved")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetAssignmentApprovalStatus>))]
    TargetAssignmentApprovalStatus Approved,
    [property: JsonPropertyName("maintenanceType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceType>))]
    MaintenanceType MaintenanceType,
    [property: JsonPropertyName("target")] string? Target,
    [property: JsonPropertyName("targetAssignmentId")]
    int TargetAssignmentId,
    [property: JsonPropertyName("targetType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetType>))]
    TargetType TargetType);
