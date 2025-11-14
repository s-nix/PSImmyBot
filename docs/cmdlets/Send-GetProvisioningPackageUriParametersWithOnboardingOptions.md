---
title: Send-GetProvisioningPackageUriParametersWithOnboardingOptions
---

# Send-GetProvisioningPackageUriParametersWithOnboardingOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetProvisioningPackageUriParametersWithOnboardingOptions` |
| Source | `Cmdlets/SendGetProvisioningPackageUriParametersWithOnboardingOptions.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/provisioning-package-uri-with-onboarding? |
| Return Type | [GetProvisioningPackageUriParametersWithOnboardingOptions](../models/GetProvisioningPackageUriParametersWithOnboardingOptions.md), string |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/provisioning-package-uri-with-onboarding?` and deserializes to [GetProvisioningPackageUriParametersWithOnboardingOptions](../models/GetProvisioningPackageUriParametersWithOnboardingOptions.md), string.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | [GetProvisioningPackageUriParametersWithOnboardingOptions](../models/GetProvisioningPackageUriParametersWithOnboardingOptions.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [GetProvisioningPackageUriParametersWithOnboardingOptions](../models/GetProvisioningPackageUriParametersWithOnboardingOptions.md), string records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
