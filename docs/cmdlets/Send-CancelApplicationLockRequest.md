---
title: Send-CancelApplicationLockRequest
---

# Send-CancelApplicationLockRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendCancelApplicationLockRequest` |
| Source | `Cmdlets/SendCancelApplicationLockRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/application-locks/request-cancellation? |
| Return Type | `CancelApplicationLockRequest, OpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/application-locks/request-cancellation?` and deserializes to `CancelApplicationLockRequest, OpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `CancelApplicationLockRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `CancelApplicationLockRequest, OpResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
