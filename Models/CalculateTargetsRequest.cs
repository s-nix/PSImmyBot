using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CalculateTargetsRequest(
    [property: JsonPropertyName("allowAccessToParentTenant")]
    bool AllowAccessToParentTenant,
    [property: JsonPropertyName("onboardingOnly")]
    bool OnboardingOnly,
    [property: JsonPropertyName("propagateToChildTenants")]
    bool PropagateToChildTenants,
    [property: JsonPropertyName("providerClientGroupType")]
    Guid? ProviderClientGroupType,
    [property: JsonPropertyName("providerDeviceGroupType")]
    Guid? ProviderDeviceGroupType,
    [property: JsonPropertyName("providerLinkId")]
    int? ProviderLinkId,
    [property: JsonPropertyName("target")] string? Target,
    [property: JsonPropertyName("targetGroupFilter")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetGroupFilter>))]
    TargetGroupFilter TargetGroupFilter,
    [property: JsonPropertyName("targetType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetType>))]
    TargetType TargetType,
    [property: JsonPropertyName("tenantId")]
    int? TenantId);
