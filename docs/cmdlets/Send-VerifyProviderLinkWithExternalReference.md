---
title: Send-VerifyProviderLinkWithExternalReference
---

# Send-VerifyProviderLinkWithExternalReference

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendVerifyProviderLinkWithExternalReference` |
| Source | `Cmdlets/SendVerifyProviderLinkWithExternalReference.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/verify-with-external-provider-reference? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/verify-with-external-provider-reference?`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateProviderLinkWithExternalProviderReferenceRequestBody](../models/CreateProviderLinkWithExternalProviderReferenceRequestBody.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `Varies/none` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
