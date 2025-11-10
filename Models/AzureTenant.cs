using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenant(
    [property: JsonPropertyName("azureTenantLinks")]
    ICollection<AzureTenantLink>? AzureTenantLinks,
    [property: JsonPropertyName("azureTenantType")]
    [property: System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AzTenantType>))]
    AzTenantType AzureTenantType,
    [property: JsonPropertyName("consentDetails")]
    [property: System.ComponentModel.DataAnnotations.Required]
    AzureTenantConsentDetails ConsentDetails,
    [property: JsonPropertyName("infoSyncedFromAzure")]
    AzureTenantInfo InfoSyncedFromAzure,
    [property: JsonPropertyName("lastGetTenantInfoSyncResult")]
    AzureSyncResult LastGetTenantInfoSyncResult,
    [property: JsonPropertyName("lastGetUsersSyncResult")]
    AzureSyncResult LastGetUsersSyncResult,
    [property: JsonPropertyName("parentPartner")]
    AzureTenant ParentPartner,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId,
    [property: JsonPropertyName("principalId")]
    string? PrincipalId);
