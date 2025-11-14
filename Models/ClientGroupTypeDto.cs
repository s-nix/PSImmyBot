using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ClientGroupTypeDto(
    [property: JsonPropertyName("clientGroupTypeId")]
    Guid ClientGroupTypeId,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId);
