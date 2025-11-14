---
title: New-ApplicationPreferences
---

# New-ApplicationPreferences

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewApplicationPreferences` |
| Source | `Cmdlets/NewApplicationPreferences.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AllowNonAdminsAndNonMspUsersToUseTerminalsAndEditScripts | `Boolean` | True | — | All | None |
| AllowNonAdminsToManageAssignments | `Boolean` | True | — | All | None |
| AutomaticImmyBotReleaseUpdateHour | `Int32` | True | — | All | None |
| DaysToWaitBeforeAutomaticImmyBotUpdate | `Int32` | True | — | All | None |
| DefaultBranding | `Branding` | True | — | All | None |
| DefaultBrandingId | `Nullable`1` | False | — | All | None |
| DefaultEmailBccList | `DefaultEmailBccList` | True | — | All | None |
| DefaultScriptTimeouts | `DefaultScriptTimeouts` | True | — | All | None |
| DefaultTimeZone | `String` | False | — | All | None |
| DisconnectLeastActiveEditorServiceWhenLimitReached | `Boolean` | True | — | All | None |
| EnableAutomaticImmyBotReleaseUpdates | `Boolean` | True | — | All | None |
| EnableAzureUserSync | `Boolean` | True | — | All | None |
| EnableBetaDynamicIntegrationMigrations | `Boolean` | True | — | All | None |
| EnableEphemeralAgentDebugMode | `Boolean` | True | — | All | None |
| EnableHistoricalInventory | `Boolean` | True | — | All | None |
| EnableImmyBotRemoteControl | `Boolean` | True | — | All | None |
| EnableImmyBotRemoteControlRecording | `Boolean` | True | — | All | None |
| EnableMaintenanceActionActivities | `Boolean` | True | — | All | None |
| EnableNiniteIntegration | `Boolean` | True | — | All | None |
| EnableNonEssentialDeviceInventory | `Boolean` | True | — | All | None |
| EnableOnboarding | `Boolean` | True | — | All | None |
| EnablePreflightScripts | `Boolean` | True | — | All | None |
| EnableProviderAuditLogging | `Boolean` | True | — | All | None |
| EnableRequestAccess | `Boolean` | True | — | All | None |
| EnableSessionEmails | `Boolean` | True | — | All | None |
| EnableUserAffinitySync | `Boolean` | True | — | All | None |
| EnableUserImpersonation | `Boolean` | True | — | All | None |
| HideChocolateyPackages | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| ImmyScriptPath | `String` | False | — | All | None |
| MspNonAdminsRequireChangeRequestsForCrossTenantDeployments | `Boolean` | True | — | All | None |
| OverwriteExistingDeviceIfOsIsNew | `Boolean` | True | — | All | None |
| ProviderAuditLogRetentionMonths | `Int32` | True | — | All | None |
| RequireConsentForExternalSessionProviders | `Boolean` | True | — | All | None |
| RunScheduledInventoryAsMaintenanceSessions | `Boolean` | True | — | All | None |
| ShowGettingStartedWizard | `Boolean` | True | — | All | None |
| StaleComputersLastAgentConnectionAgeDays | `Int32` | True | — | All | None |
| UseImmyBotChocolateyFeed | `Boolean` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
