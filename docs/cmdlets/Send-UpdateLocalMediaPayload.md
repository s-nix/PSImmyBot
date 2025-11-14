---
title: Send-UpdateLocalMediaPayload
---

# Send-UpdateLocalMediaPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateLocalMediaPayload` |
| Source | `Cmdlets/SendUpdateLocalMediaPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/media/local/{Id}? |
| Return Type | `UpdateLocalMediaPayload, LocalMediaResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/media/local/{Id}?` and deserializes to `UpdateLocalMediaPayload, LocalMediaResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdateLocalMediaPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateLocalMediaPayload, LocalMediaResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
