using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SubscriptionFeatureBasicInfo(
    [property: JsonPropertyName("featureDescription")]
    string? FeatureDescription,
    [property: JsonPropertyName("featureId")]
    string? FeatureId,
    [property: JsonPropertyName("featureName")]
    string? FeatureName,
    [property: JsonPropertyName("levels")] ICollection<SubscriptionFeatureLevelInfo> Levels,
    [property: JsonPropertyName("status")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubscriptionFeatureStatus>))]
    SubscriptionFeatureStatus Status,
    [property: JsonPropertyName("type")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubscriptionFeatureType>))]
    SubscriptionFeatureType Type,
    [property: JsonPropertyName("unit")] string? Unit);
