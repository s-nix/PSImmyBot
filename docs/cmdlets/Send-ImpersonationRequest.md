---
title: Send-ImpersonationRequest
---

# Send-ImpersonationRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendImpersonationRequest` |
| Source | `Cmdlets/SendImpersonationRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/users/{UserId}/impersonate? |
| Return Type | [ImpersonationRequest](../models/ImpersonationRequest.md), [OpResult](../models/OpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/{UserId}/impersonate?` and deserializes to [ImpersonationRequest](../models/ImpersonationRequest.md), [OpResult](../models/OpResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [ImpersonationRequest](../models/ImpersonationRequest.md) | True | — | All | None |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [ImpersonationRequest](../models/ImpersonationRequest.md), [OpResult](../models/OpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
