using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateAzureTenantLinkRequest(
    [property: JsonPropertyName("limitToDomains")]
    ICollection<string>? LimitToDomains,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId,
    [property: JsonPropertyName("principalId")]
    string? PrincipalId,
    [property: JsonPropertyName("removeCustomersSyncedUsers")]
    bool RemoveCustomersSyncedUsers,
    [property: JsonPropertyName("removeSyncedUsers")]
    bool RemoveSyncedUsers,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("unlinkCustomers")]
    bool UnlinkCustomers);
