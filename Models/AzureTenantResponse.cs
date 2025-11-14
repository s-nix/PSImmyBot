using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantResponse(
    [property: JsonPropertyName("azureTenantType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AzTenantType>))]
    AzTenantType AzureTenantType,
    [property: JsonPropertyName("consentDetails")]
    AzureTenantConsentDetails ConsentDetails,
    [property: JsonPropertyName("infoSyncedFromAzure")]
    AzureTenantInfo InfoSyncedFromAzure,
    [property: JsonPropertyName("lastGetTenantInfoSyncResult")]
    AzureSyncResult LastGetTenantInfoSyncResult,
    [property: JsonPropertyName("lastGetUsersSyncResult")]
    AzureSyncResult LastGetUsersSyncResult,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId,
    [property: JsonPropertyName("principalId")]
    string? PrincipalId);
