using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SubscriptionAddonDto(
    [property: JsonPropertyName("addonId")]
    string? AddonId,
    [property: JsonPropertyName("price")] int? Price,
    [property: JsonPropertyName("quantity")]
    int? Quantity,
    [property: JsonPropertyName("trialEndUtc")]
    DateTimeOffset? TrialEndUtc);
