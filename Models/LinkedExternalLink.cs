using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LinkedExternalLink(
    [property: JsonPropertyName("isExternalClientLinkingEnabled")]
    bool IsExternalClientLinkingEnabled,
    [property: JsonPropertyName("isExternalProviderInitializedFromThisProvider")]
    bool IsExternalProviderInitializedFromThisProvider,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,
    [property: JsonPropertyName("providerLinkName")]
    string? ProviderLinkName,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId);
