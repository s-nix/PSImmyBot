---
title: Get-ImmyIClientGroup
---

# Get-ImmyIClientGroup

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetIClientGroup` |
| Source | `Cmdlets/GetIClientGroup.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-types/client-group-types/{ClientGroupTypeId}/client-groups? |
| Return Type | List<[IClientGroup](../models/IClientGroup.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-types/client-group-types/{ClientGroupTypeId}/client-groups?` and deserializes to List<[IClientGroup](../models/IClientGroup.md)>.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ClientGroupTypeId | `String` | True | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |
| TenantId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- List<[IClientGroup](../models/IClientGroup.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
