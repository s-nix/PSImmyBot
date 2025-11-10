using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetPreferencesResponse(
    [property: JsonPropertyName("applicationPreferences")]
    ApplicationPreferences ApplicationPreferences,
    [property: JsonPropertyName("tenantPreferences")]
    TenantPreferences TenantPreferences,
    [property: JsonPropertyName("userPreferences")]
    UserPreferences UserPreferences);
