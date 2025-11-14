---
title: Send-ClearApplicationLogSourceContextRequest
---

# Send-ClearApplicationLogSourceContextRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendClearApplicationLogSourceContextRequest` |
| Source | `Cmdlets/SendClearApplicationLogSourceContextRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/application-logs/source-context/clear? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/application-logs/source-context/clear?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `ClearApplicationLogSourceContextRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
