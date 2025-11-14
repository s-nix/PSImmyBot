using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateLinkedProviderReferenceRequestBody(
    [property: JsonPropertyName("isCrossProviderClientExternalLinkingEnabled")]
    bool IsCrossProviderClientExternalLinkingEnabled,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId);
