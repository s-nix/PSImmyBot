---
title: Send-ImmyGetBashInstallScriptParametersWithOnboardingOptions
---

# Send-ImmyGetBashInstallScriptParametersWithOnboardingOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetBashInstallScriptParametersWithOnboardingOptions` |
| Source | `Cmdlets/SendGetBashInstallScriptParametersWithOnboardingOptions.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/bash-install-script-with-onboarding? |
| Return Type | [GetBashInstallScriptParametersWithOnboardingOptions](../models/GetBashInstallScriptParametersWithOnboardingOptions.md), [IScript](../models/IScript.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/bash-install-script-with-onboarding?` and deserializes to [GetBashInstallScriptParametersWithOnboardingOptions](../models/GetBashInstallScriptParametersWithOnboardingOptions.md), [IScript](../models/IScript.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [GetBashInstallScriptParametersWithOnboardingOptions](../models/GetBashInstallScriptParametersWithOnboardingOptions.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetBashInstallScriptParametersWithOnboardingOptions](../models/GetBashInstallScriptParametersWithOnboardingOptions.md), [IScript](../models/IScript.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
