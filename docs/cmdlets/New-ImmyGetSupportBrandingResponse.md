---
title: New-ImmyGetSupportBrandingResponse
---

# New-ImmyGetSupportBrandingResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetSupportBrandingResponse` |
| Source | `Cmdlets/NewGetSupportBrandingResponse.cs` |
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
| DescriptionAlertMessage | `String` | False | — | All | None |
| DescriptionPlaceholderText | `String` | False | — | All | None |
| FooterMessage | `String` | False | — | All | None |
| HeaderAlertMessage | `String` | False | — | All | None |
| ProviderId | `Guid` | True | — | All | None |
| SessionSupportButtonTitle | `String` | False | — | All | None |
| ShowConfirmationCheckbox | `Boolean` | True | — | All | None |
| ShowSessionSupportConfirmCheckbox | `Boolean` | True | — | All | None |
| SupportSidebarTitle | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
