using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record ApplicationPreferences {
    [JsonConstructor]
    [Obsolete]
    public ApplicationPreferences(bool @allowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts, bool @allowNonAdminsToManageAssignments, int @automaticImmyBotReleaseUpdateHour, int @daysToWaitBeforeAutomaticImmyBotUpdate, Branding @defaultBranding, int? @defaultBrandingId, DefaultEmailBccList @defaultEmailBccList, DefaultScriptTimeouts @defaultScriptTimeouts, string? @defaultTimeZone, bool @disconnectLeastActiveEditorServiceWhenLimitReached, bool @enableAutomaticImmyBotReleaseUpdates, bool @enableAzureUserSync, bool @enableBetaDynamicIntegrationMigrations, bool @enableEphemeralAgentDebugMode, bool @enableHistoricalInventory, bool @enableImmyBotRemoteControl, bool @enableImmyBotRemoteControlRecording, bool @enableMaintenanceActionActivities, bool @enableNiniteIntegration, bool @enableNonEssentialDeviceInventory, bool @enableOnboarding, bool @enablePreflightScripts, bool @enableProviderAuditLogging, bool @enableRequestAccess, bool @enableSessionEmails, bool @enableUserAffinitySync, bool @enableUserImpersonation, bool @hideChocolateyPackages, int @id, string? @immyScriptPath, bool @mspNonAdminsRequireChangeRequestsForCrossTenantDeployments, bool overwriteExistingDeviceIfOsIsNew, int @providerAuditLogRetentionMonths, bool @requireConsentForExternalSessionProviders, bool @runScheduledInventoryAsMaintenanceSessions, bool @showGettingStartedWizard, int @staleComputersLastAgentConnectionAgeDays, bool @useImmyBotChocolateyFeed) {
        Id = @id;
        EnableOnboarding = @enableOnboarding;
        EnableAzureUserSync = @enableAzureUserSync;
        DefaultEmailBccList = @defaultEmailBccList;
        EnableNiniteIntegration = @enableNiniteIntegration;
        DefaultBrandingId = @defaultBrandingId;
        EnableUserAffinitySync = @enableUserAffinitySync;
        EnableSessionEmails = @enableSessionEmails;
        DefaultBranding = @defaultBranding;
        DefaultScriptTimeouts = @defaultScriptTimeouts;
        UseImmyBotChocolateyFeed = @useImmyBotChocolateyFeed;
        HideChocolateyPackages = @hideChocolateyPackages;
        OverwriteExistingDeviceIfOsIsNew = overwriteExistingDeviceIfOsIsNew;
        EnableNonEssentialDeviceInventory = @enableNonEssentialDeviceInventory;
        RequireConsentForExternalSessionProviders = @requireConsentForExternalSessionProviders;
        AllowNonAdminsToManageAssignments = @allowNonAdminsToManageAssignments;
        ShowGettingStartedWizard = @showGettingStartedWizard;
        EnableHistoricalInventory = @enableHistoricalInventory;
        DefaultTimeZone = @defaultTimeZone;
        ImmyScriptPath = @immyScriptPath;
        EnableRequestAccess = @enableRequestAccess;
        EnableEphemeralAgentDebugMode = @enableEphemeralAgentDebugMode;
        StaleComputersLastAgentConnectionAgeDays = @staleComputersLastAgentConnectionAgeDays;
        AllowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts = @allowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts;
        EnablePreflightScripts = @enablePreflightScripts;
        EnableImmyBotRemoteControl = @enableImmyBotRemoteControl;
        EnableImmyBotRemoteControlRecording = @enableImmyBotRemoteControlRecording;
        EnableProviderAuditLogging = @enableProviderAuditLogging;
        ProviderAuditLogRetentionMonths = @providerAuditLogRetentionMonths;
        MspNonAdminsRequireChangeRequestsForCrossTenantDeployments = @mspNonAdminsRequireChangeRequestsForCrossTenantDeployments;
        EnableMaintenanceActionActivities = @enableMaintenanceActionActivities;
        EnableAutomaticImmyBotReleaseUpdates = @enableAutomaticImmyBotReleaseUpdates;
        AutomaticImmyBotReleaseUpdateHour = @automaticImmyBotReleaseUpdateHour;
        DaysToWaitBeforeAutomaticImmyBotUpdate = @daysToWaitBeforeAutomaticImmyBotUpdate;
        RunScheduledInventoryAsMaintenanceSessions = @runScheduledInventoryAsMaintenanceSessions;
        EnableBetaDynamicIntegrationMigrations = @enableBetaDynamicIntegrationMigrations;
        EnableUserImpersonation = @enableUserImpersonation;
        DisconnectLeastActiveEditorServiceWhenLimitReached = @disconnectLeastActiveEditorServiceWhenLimitReached;
    }

    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("enableOnboarding")]
    public bool EnableOnboarding { get; init; }

    [JsonPropertyName("enableAzureUserSync")]
    public bool EnableAzureUserSync { get; init; }

    [JsonPropertyName("defaultEmailBccList")]
    public DefaultEmailBccList DefaultEmailBccList { get; init; }

    [JsonPropertyName("enableNiniteIntegration")]
    public bool EnableNiniteIntegration { get; init; }

    [JsonPropertyName("defaultBrandingId")]
    public int? DefaultBrandingId { get; init; }

    [JsonPropertyName("enableUserAffinitySync")]
    public bool EnableUserAffinitySync { get; init; }

    [JsonPropertyName("enableSessionEmails")]
    public bool EnableSessionEmails { get; init; }

    [JsonPropertyName("defaultBranding")]
    public Branding DefaultBranding { get; init; }

    [JsonPropertyName("defaultScriptTimeouts")]
    public DefaultScriptTimeouts DefaultScriptTimeouts { get; init; }

    [JsonPropertyName("useImmyBotChocolateyFeed")]
    public bool UseImmyBotChocolateyFeed { get; init; }

    [JsonPropertyName("hideChocolateyPackages")]
    public bool HideChocolateyPackages { get; init; }

    [JsonPropertyName("overwriteExistingDeviceIfOSIsNew")]
    public bool OverwriteExistingDeviceIfOsIsNew { get; init; }

    [JsonPropertyName("enableNonEssentialDeviceInventory")]
    public bool EnableNonEssentialDeviceInventory { get; init; }

    [JsonPropertyName("requireConsentForExternalSessionProviders")]
    public bool RequireConsentForExternalSessionProviders { get; init; }

    [JsonPropertyName("allowNonAdminsToManageAssignments")]
    [Obsolete]
    public bool AllowNonAdminsToManageAssignments { get; init; }

    [JsonPropertyName("showGettingStartedWizard")]
    public bool ShowGettingStartedWizard { get; init; }

    [JsonPropertyName("enableHistoricalInventory")]
    public bool EnableHistoricalInventory { get; init; }

    [JsonPropertyName("defaultTimeZone")]
    public string? DefaultTimeZone { get; init; }

    [JsonPropertyName("immyScriptPath")]
    public string? ImmyScriptPath { get; init; }

    [JsonPropertyName("enableRequestAccess")]
    public bool EnableRequestAccess { get; init; }

    [JsonPropertyName("enableEphemeralAgentDebugMode")]
    [Obsolete]
    public bool EnableEphemeralAgentDebugMode { get; init; }

    [JsonPropertyName("staleComputersLastAgentConnectionAgeDays")]
    public int StaleComputersLastAgentConnectionAgeDays { get; init; }

    [JsonPropertyName("allowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts")]
    [Obsolete]
    public bool AllowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts { get; init; }

    [JsonPropertyName("enablePreflightScripts")]
    public bool EnablePreflightScripts { get; init; }

    [JsonPropertyName("enableImmyBotRemoteControl")]
    public bool EnableImmyBotRemoteControl { get; init; }

    [JsonPropertyName("enableImmyBotRemoteControlRecording")]
    public bool EnableImmyBotRemoteControlRecording { get; init; }

    [JsonPropertyName("enableProviderAuditLogging")]
    public bool EnableProviderAuditLogging { get; init; }

    [JsonPropertyName("providerAuditLogRetentionMonths")]
    public int ProviderAuditLogRetentionMonths { get; init; }

    [JsonPropertyName("mspNonAdminsRequireChangeRequestsForCrossTenantDeployments")]
    [Obsolete]
    public bool MspNonAdminsRequireChangeRequestsForCrossTenantDeployments { get; init; }

    [JsonPropertyName("enableMaintenanceActionActivities")]
    public bool EnableMaintenanceActionActivities { get; init; }

    [JsonPropertyName("enableAutomaticImmyBotReleaseUpdates")]
    public bool EnableAutomaticImmyBotReleaseUpdates { get; init; }

    [JsonPropertyName("automaticImmyBotReleaseUpdateHour")]
    public int AutomaticImmyBotReleaseUpdateHour { get; init; }

    [JsonPropertyName("daysToWaitBeforeAutomaticImmyBotUpdate")]
    public int DaysToWaitBeforeAutomaticImmyBotUpdate { get; init; }

    [JsonPropertyName("runScheduledInventoryAsMaintenanceSessions")]
    public bool RunScheduledInventoryAsMaintenanceSessions { get; init; }

    [JsonPropertyName("enableBetaDynamicIntegrationMigrations")]
    public bool EnableBetaDynamicIntegrationMigrations { get; init; }

    [JsonPropertyName("enableUserImpersonation")]
    public bool EnableUserImpersonation { get; init; }

    [JsonPropertyName("disconnectLeastActiveEditorServiceWhenLimitReached")]
    public bool DisconnectLeastActiveEditorServiceWhenLimitReached { get; init; }
}
