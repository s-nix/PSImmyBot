using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SubscriptionFeatureLevelInfo(
    [property: JsonPropertyName("isUnlimited")]
    bool IsUnlimited, [property: JsonPropertyName("level")] int Level, [property: JsonPropertyName("name")] string? Name, [property: JsonPropertyName("value")] string? Value);
