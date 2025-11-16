---
title: Get-ImmyMetricsProviderLinks
---

# Get-ImmyMetricsProviderLinks

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetMetricsProviderLinks` |
| Source | `Cmdlets/GetMetricsProviderLinks.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/metrics/provider-links? |
| Return Type | `byte[]` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/metrics/provider-links?` and deserializes to `byte[]`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `byte[]` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
