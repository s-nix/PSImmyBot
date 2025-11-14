---
title: Get-IDeviceGroup
---

# Get-IDeviceGroup

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetIDeviceGroup` |
| Source | `Cmdlets/GetIDeviceGroup.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/provider-types/device-group-types/{DeviceGroupTypeId}/device-groups? |
| Return Type | `List<IDeviceGroup>` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/provider-types/device-group-types/{DeviceGroupTypeId}/device-groups?` and deserializes to `List<IDeviceGroup>`.
- Builds query strings using `Globals.ConvertToQueryParameters` to keep parameter encoding consistent.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| DeviceGroupTypeId | `String` | True | — | All | None |
| ExternalClientId | `String` | False | — | All | None |
| ProviderLinkId | `Nullable`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- `List<IDeviceGroup>` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
