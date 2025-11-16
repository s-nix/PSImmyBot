---
title: New-ImmyTenantPreferences
---

# New-ImmyTenantPreferences

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTenantPreferences` |
| Source | `Cmdlets/NewTenantPreferences.cs` |
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
| BusinessHoursEnd | `String` | False | — | All | None |
| BusinessHoursStart | `String` | False | — | All | None |
| DefaultEmailBccList | [DefaultEmailBccList](../models/DefaultEmailBccList.md) | True | — | All | None |
| EnableImmyBotRemoteControl | `Nullable`1` | False | — | All | None |
| EnableImmyBotRemoteControlRecording | `Nullable`1` | False | — | All | None |
| EnableOnboarding | `Boolean` | True | — | All | None |
| EnableOnboardingPatching | `Boolean` | True | — | All | None |
| EnableSessionEmails | `Boolean` | True | — | All | None |
| EnableUserAffinitySync | `Boolean` | True | — | All | None |
| ExcludeFromCrossTenantDeploymentsAndSchedules | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| OverwriteExistingDeviceIfOsIsNew | `Boolean` | True | — | All | None |
| OwnerTenant | [Tenant](../models/Tenant.md) | True | — | All | None |
| RequireConsentForExternalSessionProviders | `Nullable`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TimeZoneInfoId | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
