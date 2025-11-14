---
title: Send-FastCreateLocalVersionRequestBody
---

# Send-FastCreateLocalVersionRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendFastCreateLocalVersionRequestBody` |
| Source | `Cmdlets/SendFastCreateLocalVersionRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/local/fast-create? |
| Return Type | `FastCreateLocalVersionRequestBody, GetLocalSoftwareResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/local/fast-create?` and deserializes to `FastCreateLocalVersionRequestBody, GetLocalSoftwareResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `FastCreateLocalVersionRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `FastCreateLocalVersionRequestBody, GetLocalSoftwareResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
