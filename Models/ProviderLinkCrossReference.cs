using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderLinkCrossReference(
    [property: JsonPropertyName("isExternalClientLinkingEnabled")]
    bool IsExternalClientLinkingEnabled,
    [property: JsonPropertyName("isProviderLink2InitializedFromProviderLink1")]
    bool IsProviderLink2InitializedFromProviderLink1,
    [property: JsonPropertyName("providerLink1")]
    ProviderLink ProviderLink1,
    [property: JsonPropertyName("providerLink1Id")]
    int ProviderLink1Id,
    [property: JsonPropertyName("providerLink2")]
    ProviderLink ProviderLink2,
    [property: JsonPropertyName("providerLink2Id")]
    int ProviderLink2Id);
