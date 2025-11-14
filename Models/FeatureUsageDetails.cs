using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record FeatureUsageDetails(
    [property: JsonPropertyName("featureTrackStartDateUtc")]
    DateTimeOffset? FeatureTrackStartDateUtc,
    [property: JsonPropertyName("itemCount")]
    int? ItemCount,
    [property: JsonPropertyName("maxCount")]
    int? MaxCount,
    [property: JsonPropertyName("maxCountPerItem")]
    int? MaxCountPerItem,
    [property: JsonPropertyName("resetInterval")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<FeatureResetInterval>))]
    FeatureResetInterval ResetInterval);
