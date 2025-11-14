using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetProviderClientResponse(
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("externalClientId")]
    string? ExternalClientId,
    [property: JsonPropertyName("externalClientName")]
    string? ExternalClientName,
    [property: JsonPropertyName("internalData")]
    object? InternalData,
    [property: JsonPropertyName("linkedToTenantId")]
    int? LinkedToTenantId,
    [property: JsonPropertyName("providerLink")]
    GetProviderLinkResponse ProviderLink,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,
    [property: JsonPropertyName("status")] string? Status,
    [property: JsonPropertyName("types")] ICollection<string>? Types,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc);
