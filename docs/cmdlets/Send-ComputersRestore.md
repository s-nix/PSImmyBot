---
title: Send-ComputersRestore
---

# Send-ComputersRestore

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendComputersRestore` |
| Source | `Cmdlets/SendComputersRestore.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/restore? |
| Return Type | `object, bool` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/restore?` and deserializes to `object, bool`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `Object` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `object, bool` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
