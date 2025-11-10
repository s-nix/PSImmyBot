using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BillingPlatformDetails(
    [property: JsonPropertyName("siteName")]
    string? SiteName);
