---
title: Push-UpdatePersonPayload
---

# Push-UpdatePersonPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.PushUpdatePersonPayload` |
| Source | `Cmdlets/PushUpdatePersonPayload.cs` |
| HTTP Method | PUT |
| Endpoint | /api/v1/persons/{Id}? |
| Return Type | `UpdatePersonPayload, GetSimplePersonResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.PUT` targeting `/api/v1/persons/{Id}?` and deserializes to `UpdatePersonPayload, GetSimplePersonResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `UpdatePersonPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `UpdatePersonPayload, GetSimplePersonResponse` records produced by `ImmyBotApiService.PUT`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
