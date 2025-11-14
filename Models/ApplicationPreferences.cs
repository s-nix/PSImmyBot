using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ApplicationPreferences(
    [property: JsonPropertyName("allowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts")]
    [property: Obsolete]
    bool AllowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts,

    [property: JsonPropertyName("allowNonAdminsToManageAssignments")]
    [property: Obsolete]
    bool AllowNonAdminsToManageAssignments,

    [property: JsonPropertyName("automaticImmyBotReleaseUpdateHour")]
    int AutomaticImmyBotReleaseUpdateHour,

    [property: JsonPropertyName("daysToWaitBeforeAutomaticImmyBotUpdate")]
    int DaysToWaitBeforeAutomaticImmyBotUpdate,

    [property: JsonPropertyName("defaultBranding")]
    Branding DefaultBranding,

    [property: JsonPropertyName("defaultBrandingId")]
    int? DefaultBrandingId,

    [property: JsonPropertyName("defaultEmailBccList")]
    DefaultEmailBccList DefaultEmailBccList,

    [property: JsonPropertyName("defaultScriptTimeouts")]
    DefaultScriptTimeouts DefaultScriptTimeouts,

    [property: JsonPropertyName("defaultTimeZone")]
    string? DefaultTimeZone,

    [property: JsonPropertyName("disconnectLeastActiveEditorServiceWhenLimitReached")]
    bool DisconnectLeastActiveEditorServiceWhenLimitReached,

    [property: JsonPropertyName("enableAutomaticImmyBotReleaseUpdates")]
    bool EnableAutomaticImmyBotReleaseUpdates,

    [property: JsonPropertyName("enableAzureUserSync")]
    bool EnableAzureUserSync,

    [property: JsonPropertyName("enableBetaDynamicIntegrationMigrations")]
    bool EnableBetaDynamicIntegrationMigrations,

    [property: JsonPropertyName("enableEphemeralAgentDebugMode")]
    [property: Obsolete]
    bool EnableEphemeralAgentDebugMode,

    [property: JsonPropertyName("enableHistoricalInventory")]
    bool EnableHistoricalInventory,

    [property: JsonPropertyName("enableImmyBotRemoteControl")]
    bool EnableImmyBotRemoteControl,

    [property: JsonPropertyName("enableImmyBotRemoteControlRecording")]
    bool EnableImmyBotRemoteControlRecording,

    [property: JsonPropertyName("enableMaintenanceActionActivities")]
    bool EnableMaintenanceActionActivities,

    [property: JsonPropertyName("enableNiniteIntegration")]
    bool EnableNiniteIntegration,

    [property: JsonPropertyName("enableNonEssentialDeviceInventory")]
    bool EnableNonEssentialDeviceInventory,

    [property: JsonPropertyName("enableOnboarding")]
    bool EnableOnboarding,

    [property: JsonPropertyName("enablePreflightScripts")]
    bool EnablePreflightScripts,

    [property: JsonPropertyName("enableProviderAuditLogging")]
    bool EnableProviderAuditLogging,

    [property: JsonPropertyName("enableRequestAccess")]
    bool EnableRequestAccess,

    [property: JsonPropertyName("enableSessionEmails")]
    bool EnableSessionEmails,

    [property: JsonPropertyName("enableUserAffinitySync")]
    bool EnableUserAffinitySync,

    [property: JsonPropertyName("enableUserImpersonation")]
    bool EnableUserImpersonation,

    [property: JsonPropertyName("hideChocolateyPackages")]
    bool HideChocolateyPackages,

    [property: JsonPropertyName("id")]
    int Id,

    [property: JsonPropertyName("immyScriptPath")]
    string? ImmyScriptPath,

    [property: JsonPropertyName("mspNonAdminsRequireChangeRequestsForCrossTenantDeployments")]
    [property: Obsolete]
    bool MspNonAdminsRequireChangeRequestsForCrossTenantDeployments,

    [property: JsonPropertyName("overwriteExistingDeviceIfOSIsNew")]
    bool OverwriteExistingDeviceIfOsIsNew,

    [property: JsonPropertyName("providerAuditLogRetentionMonths")]
    int ProviderAuditLogRetentionMonths,

    [property: JsonPropertyName("requireConsentForExternalSessionProviders")]
    bool RequireConsentForExternalSessionProviders,

    [property: JsonPropertyName("runScheduledInventoryAsMaintenanceSessions")]
    bool RunScheduledInventoryAsMaintenanceSessions,

    [property: JsonPropertyName("showGettingStartedWizard")]
    bool ShowGettingStartedWizard,

    [property: JsonPropertyName("staleComputersLastAgentConnectionAgeDays")]
    int StaleComputersLastAgentConnectionAgeDays,

    [property: JsonPropertyName("useImmyBotChocolateyFeed")]
    bool UseImmyBotChocolateyFeed
);
