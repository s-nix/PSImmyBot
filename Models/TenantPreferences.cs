using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantPreferences(
    [property: JsonPropertyName("businessHoursEnd")]
    string? BusinessHoursEnd,
    [property: JsonPropertyName("businessHoursStart")]
    string? BusinessHoursStart,
    [property: JsonPropertyName("defaultEmailBccList")]
    DefaultEmailBccList DefaultEmailBccList,
    [property: JsonPropertyName("enableImmyBotRemoteControl")]
    bool? EnableImmyBotRemoteControl,
    [property: JsonPropertyName("enableImmyBotRemoteControlRecording")]
    bool? EnableImmyBotRemoteControlRecording,
    [property: JsonPropertyName("enableOnboarding")]
    bool EnableOnboarding,
    [property: JsonPropertyName("enableOnboardingPatching")]
    bool EnableOnboardingPatching,
    [property: JsonPropertyName("enableSessionEmails")]
    bool EnableSessionEmails,
    [property: JsonPropertyName("enableUserAffinitySync")]
    bool EnableUserAffinitySync,
    [property: JsonPropertyName("excludeFromCrossTenantDeploymentsAndSchedules")]
    bool ExcludeFromCrossTenantDeploymentsAndSchedules,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("overwriteExistingDeviceIfOSIsNew")]
    bool OverwriteExistingDeviceIfOsIsNew,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("requireConsentForExternalSessionProviders")]
    bool? RequireConsentForExternalSessionProviders,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("timeZoneInfoId")]
    string? TimeZoneInfoId);
