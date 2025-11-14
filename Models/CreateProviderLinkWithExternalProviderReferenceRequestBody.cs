using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateProviderLinkWithExternalProviderReferenceRequestBody(
    [property: JsonPropertyName("providerLink")]
    [property: System.ComponentModel.DataAnnotations.Required]
    ProviderLink ProviderLink,
    [property: JsonPropertyName("providerLinkExternalReferenceData")]
    ProviderLinkExternalReferenceDataBody ProviderLinkExternalReferenceData);
