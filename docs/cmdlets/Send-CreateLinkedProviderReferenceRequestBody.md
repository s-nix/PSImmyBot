---
title: Send-CreateLinkedProviderReferenceRequestBody
---

# Send-CreateLinkedProviderReferenceRequestBody

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateLinkedProviderReferenceRequestBody` |
| Source | `Cmdlets/SendCreateLinkedProviderReferenceRequestBody.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/provider-links/{Id}/cross-references/create? |
| Return Type | `CreateLinkedProviderReferenceRequestBody, LinkedExternalLink` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/provider-links/{Id}/cross-references/create?` and deserializes to `CreateLinkedProviderReferenceRequestBody, LinkedExternalLink`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Id | `Int32` | True | — | All | None |
| PayloadBody | `CreateLinkedProviderReferenceRequestBody` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CreateLinkedProviderReferenceRequestBody, LinkedExternalLink` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
