---
title: Remove-SoftwareGlobal
---

# Remove-SoftwareGlobal

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.RemoveSoftwareGlobal` |
| Source | `Cmdlets/RemoveSoftwareGlobal.cs` |
| HTTP Method | DELETE |
| Endpoint | /api/v1/software/global/{SoftwareIdentifier}? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.DELETE` targeting `/api/v1/software/global/{SoftwareIdentifier}?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SoftwareIdentifier | `String` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.DELETE`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
