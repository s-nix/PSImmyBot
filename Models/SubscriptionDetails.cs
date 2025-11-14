using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SubscriptionDetails(
    [property: JsonPropertyName("activatedAtUtc")]
    DateTimeOffset? ActivatedAtUtc,
    [property: JsonPropertyName("addons")] ICollection<SubscriptionAddonDto>? Addons,
    [property: JsonPropertyName("customerEmail")]
    string? CustomerEmail,
    [property: JsonPropertyName("customerId")]
    string? CustomerId,
    [property: JsonPropertyName("features")]
    ICollection<SubscriptionFeature>? Features,
    [property: JsonPropertyName("planId")] string? PlanId,
    [property: JsonPropertyName("planPrice")]
    int PlanPrice,
    [property: JsonPropertyName("planQuantity")]
    int PlanQuantity,
    [property: JsonPropertyName("status")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubscriptionStatus>))]
    SubscriptionStatus Status,
    [property: JsonPropertyName("trialEndUtc")]
    DateTimeOffset? TrialEndUtc,
    [property: JsonPropertyName("trialStartUtc")]
    DateTimeOffset? TrialStartUtc);
