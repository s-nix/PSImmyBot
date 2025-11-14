---
title: Send-GetProvisioningPackageUriParameters
---

# Send-GetProvisioningPackageUriParameters

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendGetProvisioningPackageUriParameters` |
| Source | `Cmdlets/SendGetProvisioningPackageUriParameters.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/agents/provisioning-package-uri? |
| Return Type | `GetProvisioningPackageUriParameters, string` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/agents/provisioning-package-uri?` and deserializes to `GetProvisioningPackageUriParameters, string`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `GetProvisioningPackageUriParameters` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetProvisioningPackageUriParameters, string` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
