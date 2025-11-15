---
title: Send-ComputerNotesUpdate
---

# Send-ComputerNotesUpdate

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendComputerNotesUpdate` |
| Source | `Cmdlets/SendComputerNotesUpdate.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/{ComputerId}/notes? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/{ComputerId}/notes?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| PayloadBody | [UpdateNotesPayload](../models/UpdateNotesPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
