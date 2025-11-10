using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderLinkExternalReferenceDataBody(
    [property: JsonPropertyName("enableClientExternalLinking")]
    bool EnableClientExternalLinking,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,
    [property: JsonPropertyName("providerTypeFormData")]
    object ProviderTypeFormData);
