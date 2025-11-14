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
| Return Type | [RegistryPayload](../models/RegistryPayload.md), [RegistryValueDtoArrayOpResult](../models/RegistryValueDtoArrayOpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/computers/{ComputerId}/registry/values?` and deserializes to [RegistryPayload](../models/RegistryPayload.md), [RegistryValueDtoArrayOpResult](../models/RegistryValueDtoArrayOpResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| ComputerId | `Int32` | True | — | All | None |
| PayloadBody | [RegistryPayload](../models/RegistryPayload.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [RegistryPayload](../models/RegistryPayload.md), [RegistryValueDtoArrayOpResult](../models/RegistryValueDtoArrayOpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
