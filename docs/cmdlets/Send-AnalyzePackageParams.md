---
title: Send-AnalyzePackageParams
---

# Send-AnalyzePackageParams

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendAnalyzePackageParams` |
| Source | `Cmdlets/SendAnalyzePackageParams.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/global/analyze? |
| Return Type | `AnalyzePackageParams, AnalyzeGlobalSoftwarePackageResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/global/analyze?` and deserializes to `AnalyzePackageParams, AnalyzeGlobalSoftwarePackageResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `AnalyzePackageParams` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `AnalyzePackageParams, AnalyzeGlobalSoftwarePackageResponse` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
