---
title: Send-CreatePersonPayload
---

# Send-CreatePersonPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreatePersonPayload` |
| Source | `Cmdlets/SendCreatePersonPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/persons? |
| Return Type | `CreatePersonPayload, GetSimplePersonResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/persons?` and deserializes to `CreatePersonPayload, GetSimplePersonResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreatePersonPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreatePersonPayload, GetSimplePersonResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
