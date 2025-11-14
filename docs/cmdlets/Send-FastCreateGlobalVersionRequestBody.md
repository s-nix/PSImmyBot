---
title: Send-FastCreateGlobalVersionRequestBody
---

# Send-FastCreateGlobalVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendFastCreateGlobalVersionRequestBody` |
| Source | `Cmdlets/SendFastCreateGlobalVersionRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/global/fast-create? |
| Return Type | `FastCreateGlobalVersionRequestBody, GetGlobalSoftwareResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/global/fast-create?` and deserializes to `FastCreateGlobalVersionRequestBody, GetGlobalSoftwareResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `FastCreateGlobalVersionRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `FastCreateGlobalVersionRequestBody, GetGlobalSoftwareResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
