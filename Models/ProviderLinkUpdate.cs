using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderLinkUpdate(
    [property: JsonPropertyName("clientId")]
    string? ClientId,
    [property: JsonPropertyName("deviceUpdateFormData")]
    object? DeviceUpdateFormData,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId);
