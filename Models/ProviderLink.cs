using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderLink(
    [property: JsonPropertyName("agents")] ICollection<ProviderAgent>? Agents,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("disabled")]
    bool Disabled,
    [property: JsonPropertyName("disabledOrUnhealthy")]
    bool DisabledOrUnhealthy,
    [property: JsonPropertyName("excludedCapabilities")]
    ICollection<string>? ExcludedCapabilities,
    [property: JsonPropertyName("healthStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<HealthStatus>))]
    HealthStatus HealthStatus,
    [property: JsonPropertyName("healthStatusMessage")]
    string? HealthStatusMessage,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("linkedFromProviders")]
    ICollection<ProviderLinkCrossReference>? LinkedFromProviders,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("providerClients")]
    ICollection<ProviderClient>? ProviderClients,
    [property: JsonPropertyName("providerInternalData")]
    ProviderLinkInternalData ProviderInternalData,
    [property: JsonPropertyName("providersLinkedFromThisProvider")]
    ICollection<ProviderLinkCrossReference>? ProvidersLinkedFromThisProvider,
    [property: JsonPropertyName("providerTypeFormData")]
    object ProviderTypeFormData,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId,
    [property: JsonPropertyName("runScriptPriority")]
    int RunScriptPriority,
    [property: JsonPropertyName("schedules")]
    ICollection<Schedule>? Schedules,
    [property: JsonPropertyName("targetAssignments")]
    ICollection<TargetAssignment>? TargetAssignments,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("unhealthyCount")]
    int UnhealthyCount,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
