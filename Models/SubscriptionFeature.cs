using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SubscriptionFeature(
    [property: JsonPropertyName("expiresAtUtc")]
    DateTimeOffset? ExpiresAtUtc,
    [property: JsonPropertyName("featureId")]
    string? FeatureId,
    [property: JsonPropertyName("isEnabled")]
    bool IsEnabled,
    [property: JsonPropertyName("isUnlimited")]
    bool IsUnlimited,
    [property: JsonPropertyName("value")] string? Value);
