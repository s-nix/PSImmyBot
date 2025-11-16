---
title: Connect-ImmyApi
---

# Connect-ImmyApi

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.ConnectApi` |
| Source | `Cmdlets/ConnectApi.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Uses `HttpClient` directly instead of `ImmyBotApiService` for its network call.
- Persists API configuration to the local profile when requested.
- Updates the cached API token via `Globals.SaveApiToken`.
- Writes informational messages for user feedback.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| AzureClientId | `String` | True | 1 | Direct | None |
| AzureClientSecret | `String` | True | 2 | Direct | None |
| AzureTenantDomain | `String` | True | 0 | Direct | None |
| Force | `SwitchParameter` | False | — | Direct, Saved | None |
| ImmySubdomain | `String` | True | 3 | Direct | None |
| Save | `SwitchParameter` | False | — | Direct | None |
| UseSavedConfig | `SwitchParameter` | True | — | Saved | None |

### Parameter sets

- `Direct`
- `Saved`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
