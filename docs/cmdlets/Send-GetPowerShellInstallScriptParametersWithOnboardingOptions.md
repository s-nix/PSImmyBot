---
title: Send-GetPowerShellInstallScriptParametersWithOnboardingOptions
---

# Send-GetPowerShellInstallScriptParametersWithOnboardingOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetPowerShellInstallScriptParametersWithOnboardingOptions` |
| Source | `Cmdlets/SendGetPowerShellInstallScriptParametersWithOnboardingOptions.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/powershell-install-script-with-onboarding? |
| Return Type | `GetPowerShellInstallScriptParametersWithOnboardingOptions, IScript` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/powershell-install-script-with-onboarding?` and deserializes to `GetPowerShellInstallScriptParametersWithOnboardingOptions, IScript`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `GetPowerShellInstallScriptParametersWithOnboardingOptions` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetPowerShellInstallScriptParametersWithOnboardingOptions, IScript` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
