---
title: New-ImmyAgentOnboardingOptions
---

# New-ImmyAgentOnboardingOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAgentOnboardingOptions` |
| Source | `Cmdlets/NewAgentOnboardingOptions.cs` |
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
| AdditionalPersonIds | `ICollection`1` | False | — | All | None |
| AutomaticallyOnboard | `Boolean` | True | — | All | None |
| IsDevLab | `Boolean` | True | — | All | None |
| OnboardingCorrelationId | `String` | False | — | All | None |
| OnboardingSessionAutoConsentToReboots | `Boolean` | True | — | All | None |
| OnboardingSessionPromptTimeoutAction | [PromptTimeoutAction](../models/PromptTimeoutAction.md) | True | — | All | None |
| OnboardingSessionPromptTimeoutMinutes | `Int32` | True | — | All | None |
| OnboardingSessionRebootPreference | [RebootPreference](../models/RebootPreference.md) | True | — | All | None |
| OnboardingSessionSendFollowUpEmail | `Boolean` | True | — | All | None |
| PrimaryPersonId | `Nullable`1` | False | — | All | None |
| Tags | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
