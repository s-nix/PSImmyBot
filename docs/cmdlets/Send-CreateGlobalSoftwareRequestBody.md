---
title: Send-CreateGlobalSoftwareRequestBody
---

# Send-CreateGlobalSoftwareRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateGlobalSoftwareRequestBody` |
| Source | `Cmdlets/SendCreateGlobalSoftwareRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/global? |
| Return Type | `CreateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/global?` and deserializes to `CreateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateGlobalSoftwareRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateGlobalSoftwareRequestBody, GetGlobalSoftwareResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
