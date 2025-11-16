---
title: Send-ImmyCancelApplicationLockRequest
---

# Send-ImmyCancelApplicationLockRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCancelApplicationLockRequest` |
| Source | `Cmdlets/SendCancelApplicationLockRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/application-locks/request-cancellation? |
| Return Type | [CancelApplicationLockRequest](../models/CancelApplicationLockRequest.md), [OpResult](../models/OpResult.md) |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/application-locks/request-cancellation?` and deserializes to [CancelApplicationLockRequest](../models/CancelApplicationLockRequest.md), [OpResult](../models/OpResult.md).

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | [CancelApplicationLockRequest](../models/CancelApplicationLockRequest.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- [CancelApplicationLockRequest](../models/CancelApplicationLockRequest.md), [OpResult](../models/OpResult.md) records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
