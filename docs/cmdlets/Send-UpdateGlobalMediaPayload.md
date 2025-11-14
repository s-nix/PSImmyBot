---
title: Send-UpdateGlobalMediaPayload
---

# Send-UpdateGlobalMediaPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendUpdateGlobalMediaPayload` |
| Source | `Cmdlets/SendUpdateGlobalMediaPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/media/global/{Id}? |
| Return Type | `UpdateGlobalMediaPayload, GlobalMediaResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/media/global/{Id}?` and deserializes to `UpdateGlobalMediaPayload, GlobalMediaResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdateGlobalMediaPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdateGlobalMediaPayload, GlobalMediaResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
