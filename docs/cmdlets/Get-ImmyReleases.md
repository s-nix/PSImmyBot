---
title: Get-ImmyReleases
---

# Get-ImmyReleases

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetReleases` |
| Source | `Cmdlets/GetReleases.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/system/releases? |
| Return Type | [GetReleasesResponse](../models/GetReleasesResponse.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/system/releases?` and deserializes to [GetReleasesResponse](../models/GetReleasesResponse.md).

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- [GetReleasesResponse](../models/GetReleasesResponse.md) records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
