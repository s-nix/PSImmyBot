using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetSubscriptionDetailsResponse(
    [property: JsonPropertyName("featuresEnabledFromSubscription")]
    ICollection<FeatureEnabledFromSubscription>? FeaturesEnabledFromSubscription,
    [property: JsonPropertyName("planId")] string? PlanId,
    [property: JsonPropertyName("status")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubscriptionStatus>))]
    SubscriptionStatus Status,
    [property: JsonPropertyName("subscriptionActivatedDateUtc")]
    DateTimeOffset? SubscriptionActivatedDateUtc,
    [property: JsonPropertyName("trialEndUtc")]
    DateTimeOffset? TrialEndUtc,
    [property: JsonPropertyName("trialStartUtc")]
    DateTimeOffset? TrialStartUtc);
