using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ApplicationPreferences")]
public class NewApplicationPreferences : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts { get; set; }
    [Parameter(Mandatory = true)] public required bool AllowNonAdminsToManageAssignments { get; set; }
    [Parameter(Mandatory = true)] public required int AutomaticImmyBotReleaseUpdateHour { get; set; }
    [Parameter(Mandatory = true)] public required int DaysToWaitBeforeAutomaticImmyBotUpdate { get; set; }
    [Parameter(Mandatory = true)] public required Branding DefaultBranding { get; set; }
    [Parameter(Mandatory = false)] public int? DefaultBrandingId { get; set; }
    [Parameter(Mandatory = true)] public required DefaultEmailBccList DefaultEmailBccList { get; set; }
    [Parameter(Mandatory = true)] public required DefaultScriptTimeouts DefaultScriptTimeouts { get; set; }
    [Parameter(Mandatory = false)] public string? DefaultTimeZone { get; set; }
    [Parameter(Mandatory = true)] public required bool DisconnectLeastActiveEditorServiceWhenLimitReached { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableAutomaticImmyBotReleaseUpdates { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableAzureUserSync { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableBetaDynamicIntegrationMigrations { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableEphemeralAgentDebugMode { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableHistoricalInventory { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableImmyBotRemoteControl { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableImmyBotRemoteControlRecording { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableMaintenanceActionActivities { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableNiniteIntegration { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableNonEssentialDeviceInventory { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableOnboarding { get; set; }
    [Parameter(Mandatory = true)] public required bool EnablePreflightScripts { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableProviderAuditLogging { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableRequestAccess { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableSessionEmails { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableUserAffinitySync { get; set; }
    [Parameter(Mandatory = true)] public required bool EnableUserImpersonation { get; set; }
    [Parameter(Mandatory = true)] public required bool HideChocolateyPackages { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? ImmyScriptPath { get; set; }
    [Parameter(Mandatory = true)] public required bool MspNonAdminsRequireChangeRequestsForCrossTenantDeployments { get; set; }
    [Parameter(Mandatory = true)] public required bool OverwriteExistingDeviceIfOsIsNew { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderAuditLogRetentionMonths { get; set; }
    [Parameter(Mandatory = true)] public required bool RequireConsentForExternalSessionProviders { get; set; }
    [Parameter(Mandatory = true)] public required bool RunScheduledInventoryAsMaintenanceSessions { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowGettingStartedWizard { get; set; }
    [Parameter(Mandatory = true)] public required int StaleComputersLastAgentConnectionAgeDays { get; set; }
    [Parameter(Mandatory = true)] public required bool UseImmyBotChocolateyFeed { get; set; }

    protected override void ProcessRecord() {
        ApplicationPreferences outputObject = new(AllowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts, AllowNonAdminsToManageAssignments, AutomaticImmyBotReleaseUpdateHour, DaysToWaitBeforeAutomaticImmyBotUpdate, DefaultBranding, DefaultBrandingId, DefaultEmailBccList, DefaultScriptTimeouts, DefaultTimeZone, DisconnectLeastActiveEditorServiceWhenLimitReached, EnableAutomaticImmyBotReleaseUpdates, EnableAzureUserSync, EnableBetaDynamicIntegrationMigrations, EnableEphemeralAgentDebugMode, EnableHistoricalInventory, EnableImmyBotRemoteControl, EnableImmyBotRemoteControlRecording, EnableMaintenanceActionActivities, EnableNiniteIntegration, EnableNonEssentialDeviceInventory, EnableOnboarding, EnablePreflightScripts, EnableProviderAuditLogging, EnableRequestAccess, EnableSessionEmails, EnableUserAffinitySync, EnableUserImpersonation, HideChocolateyPackages, Id, ImmyScriptPath, MspNonAdminsRequireChangeRequestsForCrossTenantDeployments, OverwriteExistingDeviceIfOsIsNew, ProviderAuditLogRetentionMonths, RequireConsentForExternalSessionProviders, RunScheduledInventoryAsMaintenanceSessions, ShowGettingStartedWizard, StaleComputersLastAgentConnectionAgeDays, UseImmyBotChocolateyFeed);
        WriteObject(outputObject);
    }
}
