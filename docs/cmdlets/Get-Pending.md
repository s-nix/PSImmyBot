---
title: Get-Pending
---

# Get-Pending

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetPending` |
| Source | `Cmdlets/GetPending.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-agents/pending? |
| Return Type | `GetPendingResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-agents/pending?` and deserializes to `GetPendingResponse`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AgentFilter | `Nullable`1` | False | — | All | None |
| Filter | `String` | False | — | All | None |
| IncludeOffline | `Nullable`1` | False | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |
| Skip | `Nullable`1` | False | — | All | None |
| Sort | `String` | False | — | All | None |
| SortDesc | `Nullable`1` | False | — | All | None |
| Take | `Nullable`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetPendingResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
