using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantTokenCredentialDetails(
    [property: JsonPropertyName("gotAccessTokenFrom")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AccessTokenSource>))]
    AccessTokenSource GotAccessTokenFrom,
    [property: JsonPropertyName("onlyUsePartnerCenterRefresh")]
    bool OnlyUsePartnerCenterRefresh,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId,
    [property: JsonPropertyName("resolvedClientId")]
    string? ResolvedClientId,
    [property: JsonPropertyName("tenantAzurePermissionLevel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AzurePermissionLevel2>))]
    AzurePermissionLevel2 TenantAzurePermissionLevel,
    [property: JsonPropertyName("tenantPreferredAzureClientId")]
    string? TenantPreferredAzureClientId,
    [property: JsonPropertyName("tenantPrincipalId")]
    string? TenantPrincipalId);
