using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderLinkInternalData(
    [property: JsonPropertyName("internalData")]
    object? InternalData,
    [property: JsonPropertyName("providerLink")]
    ProviderLink ProviderLink,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId);
