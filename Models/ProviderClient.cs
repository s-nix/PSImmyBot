using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ProviderClient(
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("externalClientId")]
    string? ExternalClientId,
    [property: JsonPropertyName("externalClientName")]
    string? ExternalClientName,
    [property: JsonPropertyName("hasCompletedInitialAgentSync")]
    bool HasCompletedInitialAgentSync,
    [property: JsonPropertyName("internalData")]
    object? InternalData,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("providerAgents")]
    ICollection<ProviderAgent>? ProviderAgents,
    [property: JsonPropertyName("providerLink")]
    ProviderLink ProviderLink,
    [property: JsonPropertyName("providerLinkId")]
    int ProviderLinkId,
    [property: JsonPropertyName("status")] string? Status,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("types")] ICollection<string>? Types,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
