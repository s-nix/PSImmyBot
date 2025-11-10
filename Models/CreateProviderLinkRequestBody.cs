using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateProviderLinkRequestBody([property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("providerTypeFormData")]
    object? ProviderTypeFormData,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId);
