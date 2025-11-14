using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record FeatureEnabledFromSubscription(
    [property: JsonPropertyName("featureCustomValue")]
    string? FeatureCustomValue,
    [property: JsonPropertyName("featureEntitlementType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<FeatureEntitlementType>))]
    FeatureEntitlementType FeatureEntitlementType,
    [property: JsonPropertyName("featureId")]
    string? FeatureId,
    [property: JsonPropertyName("featureUsage")]
    FeatureUsageDetails FeatureUsage,
    [property: JsonPropertyName("isUsageBased")]
    bool IsUsageBased);
