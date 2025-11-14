---
title: Get-ChangeRequestDiff
---

# Get-ChangeRequestDiff

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetChangeRequestDiff` |
| Source | `Cmdlets/GetChangeRequestDiff.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/target-assignments/change-request/{ChangeRequestId}/diff? |
| Return Type | [ChangeRequestDiff](../models/ChangeRequestDiff.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/target-assignments/change-request/{ChangeRequestId}/diff?` and deserializes to [ChangeRequestDiff](../models/ChangeRequestDiff.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ChangeRequestId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ChangeRequestDiff](../models/ChangeRequestDiff.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
