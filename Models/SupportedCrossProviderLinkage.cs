using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SupportedCrossProviderLinkage(
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId);
