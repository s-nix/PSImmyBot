---
title: New-ImmyGetTenantSoftwareFromInventoryResponse
---

# New-ImmyGetTenantSoftwareFromInventoryResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetTenantSoftwareFromInventoryResponse` |
| Source | `Cmdlets/NewGetTenantSoftwareFromInventoryResponse.cs` |
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
| AzureUserObjectId | `String` | False | — | All | None |
| ComputerId | `Int32` | True | — | All | None |
| ComputerName | `String` | False | — | All | None |
| DateDetectedUtc | `DateTimeOffset` | True | — | All | None |
| DisplayName | `String` | False | — | All | None |
| GlobalSoftwareId | `Int32` | True | — | All | None |
| GlobalSoftwareName | `String` | False | — | All | None |
| GlobalSoftwareVersion | `String` | False | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| PersonName | `String` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
