---
title: Send-GetExecutableUriParametersWithOnboardingOptions
---

# Send-GetExecutableUriParametersWithOnboardingOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetExecutableUriParametersWithOnboardingOptions` |
| Source | `Cmdlets/SendGetExecutableUriParametersWithOnboardingOptions.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/executable-uri-with-onboarding? |
| Return Type | [GetExecutableUriParametersWithOnboardingOptions](../models/GetExecutableUriParametersWithOnboardingOptions.md), string |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/executable-uri-with-onboarding?` and deserializes to [GetExecutableUriParametersWithOnboardingOptions](../models/GetExecutableUriParametersWithOnboardingOptions.md), string.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [GetExecutableUriParametersWithOnboardingOptions](../models/GetExecutableUriParametersWithOnboardingOptions.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetExecutableUriParametersWithOnboardingOptions](../models/GetExecutableUriParametersWithOnboardingOptions.md), string records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
