---
title: Send-RegistryPayload
---

# Send-RegistryPayload

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendRegistryPayload` |
| Source | `Cmdlets/SendRegistryPayload.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/computers/{ComputerId}/registry/values? |
| Return Type | `RegistryPayload, RegistryValueDtoArrayOpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/{ComputerId}/registry/values?` and deserializes to `RegistryPayload, RegistryValueDtoArrayOpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| PayloadBody | `RegistryPayload` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `RegistryPayload, RegistryValueDtoArrayOpResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
