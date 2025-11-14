---
title: New-FastCreateGlobalVersionRequestBody
---

# New-FastCreateGlobalVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewFastCreateGlobalVersionRequestBody` |
| Source | `Cmdlets/NewFastCreateGlobalVersionRequestBody.cs` |
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
| Software | `CreateGlobalSoftwareRequestBody` | True | — | All | None |
| SoftwareId | `Nullable`1` | False | — | All | None |
| SoftwareVersion | `CreateGlobalSoftwareVersionRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
