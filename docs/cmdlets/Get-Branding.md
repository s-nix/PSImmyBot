---
title: Get-Branding
---

# Get-Branding

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetBranding` |
| Source | `Cmdlets/GetBranding.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/brandings? |
| Return Type | List<[GetBrandingResponse](../models/GetBrandingResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/brandings?` and deserializes to List<[GetBrandingResponse](../models/GetBrandingResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[GetBrandingResponse](../models/GetBrandingResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
