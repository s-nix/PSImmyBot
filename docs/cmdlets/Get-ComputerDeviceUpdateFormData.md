---
title: Get-ComputerDeviceUpdateFormData
---

# Get-ComputerDeviceUpdateFormData

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetComputerDeviceUpdateFormData` |
| Source | `Cmdlets/GetComputerDeviceUpdateFormData.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/computers/{ComputerId}/device-update-form-data? |
| Return Type | `GetComputerDeviceUpdateFormDataResponse` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/computers/{ComputerId}/device-update-form-data?` and deserializes to `GetComputerDeviceUpdateFormDataResponse`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `GetComputerDeviceUpdateFormDataResponse` records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
