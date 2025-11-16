---
title: Send-ImmyCreateRmmLink
---

# Send-ImmyCreateRmmLink

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCreateRmmLink` |
| Source | `Cmdlets/SendCreateRmmLink.cs` |
| HTTP Method | Custom |
| Endpoint | /api/v1/rmm-links? |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CreateProviderLinkRequestBody](../models/CreateProviderLinkRequestBody.md) | True | — | All | None |
| ThrowIfAgentInstallerVersionNotSet | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
