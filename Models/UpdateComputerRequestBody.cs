using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateComputerRequestBody(
    [property: JsonPropertyName("additionalPersonIds")]
    ICollection<int>? AdditionalPersonIds,
    [property: JsonPropertyName("notes")] string? Notes,
    [property: JsonPropertyName("onboardingStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ComputerOnboardingStatus>))]
    ComputerOnboardingStatus OnboardingStatus,
    [property: JsonPropertyName("providerLinkUpdates")]
    ICollection<ProviderLinkUpdate>? ProviderLinkUpdates,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
