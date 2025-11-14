using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetComputerResponse(
    [property: JsonPropertyName("additionalPersons")]
    ICollection<GetPersonResponse>? AdditionalPersons,
    [property: JsonPropertyName("agents")] ICollection<GetProviderAgentResponse>? Agents,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("computerTagIds")]
    ICollection<int>? ComputerTagIds,
    [property: JsonPropertyName("detectionOutdated")]
    bool DetectionOutdated,
    [property: JsonPropertyName("deviceId")]
    Guid DeviceId,
    [property: JsonPropertyName("devLabVmClaimExpirationDateUtc")]
    DateTimeOffset? DevLabVmClaimExpirationDateUtc,
    [property: JsonPropertyName("devLabVmUnclaimed")]
    bool DevLabVmUnclaimed,
    [property: JsonPropertyName("ephemeralAgentConnected")]
    bool EphemeralAgentConnected,
    [property: JsonPropertyName("excludedFromUserAffinity")]
    bool ExcludedFromUserAffinity,
    [property: JsonPropertyName("excludeFromMaintenance")]
    bool ExcludeFromMaintenance,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("inventory")]
    object? Inventory,
    [property: JsonPropertyName("isDesktop")]
    bool? IsDesktop,
    [property: JsonPropertyName("isDevLab")]
    bool IsDevLab,
    [property: JsonPropertyName("isDomainController")]
    bool? IsDomainController,
    [property: JsonPropertyName("isMissingSomeRequiredInventoryResults")]
    bool? IsMissingSomeRequiredInventoryResults,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline,
    [property: JsonPropertyName("isPortable")]
    bool? IsPortable,
    [property: JsonPropertyName("isSandbox")]
    bool IsSandbox,
    [property: JsonPropertyName("isServer")]
    bool? IsServer,
    [property: JsonPropertyName("licensed")]
    bool Licensed,
    [property: JsonPropertyName("notes")] string? Notes,
    [property: JsonPropertyName("onboardingStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ComputerOnboardingStatus>))]
    ComputerOnboardingStatus OnboardingStatus,
    [property: JsonPropertyName("primaryPerson")]
    GetPersonResponse PrimaryPerson,
    [property: JsonPropertyName("primaryPersonId")]
    int? PrimaryPersonId,
    [property: JsonPropertyName("sessions")]
    ICollection<GetMaintenanceSessionResponse>? Sessions,
    [property: JsonPropertyName("tenant")] GetTenantResponse Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName);
