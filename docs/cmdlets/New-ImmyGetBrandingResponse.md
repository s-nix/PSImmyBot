---
title: New-ImmyGetBrandingResponse
---

# New-ImmyGetBrandingResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetBrandingResponse` |
| Source | `Cmdlets/NewGetBrandingResponse.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| BackgroundColor | `String` | False | — | All | None |
| CreatedDateUtc | `DateTimeOffset` | True | — | All | None |
| Description | `String` | False | — | All | None |
| EndDate | `Nullable`1` | False | — | All | None |
| ForegroundColor | `String` | False | — | All | None |
| FromAddress | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| IgnoreYear | `Nullable`1` | False | — | All | None |
| LogoAltText | `String` | False | — | All | None |
| LogoUri | `String` | False | — | All | None |
| MascotImgUri | `String` | False | — | All | None |
| MascotName | `String` | False | — | All | None |
| StartDate | `Nullable`1` | False | — | All | None |
| TableHeaderColor | `String` | False | — | All | None |
| TableHeaderTextColor | `String` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |
| TenantName | `String` | False | — | All | None |
| TextColor | `String` | False | — | All | None |
| TimeFormat | `String` | False | — | All | None |
| UpdatedBy | `String` | False | — | All | None |
| UpdatedDateUtc | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
