---
title: Get-SupportBranding
---

# Get-SupportBranding

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetSupportBranding` |
| Source | `Cmdlets/GetSupportBranding.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/brandings/support-branding? |
| Return Type | `GetSupportBrandingResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/brandings/support-branding?` and deserializes to `GetSupportBrandingResponse`.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- `GetSupportBrandingResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
