---
title: Send-CreateLocalSoftwareRequestBody
---

# Send-CreateLocalSoftwareRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLocalSoftwareRequestBody` |
| Source | `Cmdlets/SendCreateLocalSoftwareRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/local? |
| Return Type | `CreateLocalSoftwareRequestBody, GetLocalSoftwareResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/local?` and deserializes to `CreateLocalSoftwareRequestBody, GetLocalSoftwareResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CreateLocalSoftwareRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateLocalSoftwareRequestBody, GetLocalSoftwareResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
