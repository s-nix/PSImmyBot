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
| Return Type | `ImpersonationRequest, OpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/users/{UserId}/impersonate?` and deserializes to `ImpersonationRequest, OpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `ImpersonationRequest` | True | — | All | None |
| UserId | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `ImpersonationRequest, OpResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
