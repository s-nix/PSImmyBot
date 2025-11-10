using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantConsentDetails(
    [property: JsonPropertyName("consentDateUtc")]
    DateTimeOffset? ConsentDateUtc,
    [property: JsonPropertyName("consentedWith")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AppRegistrationType>))]
    AppRegistrationType ConsentedWith);
