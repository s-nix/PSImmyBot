---
title: Send-ResolveAssignmentsForMaintenanceItemRequest
---

# Send-ResolveAssignmentsForMaintenanceItemRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendResolveAssignmentsForMaintenanceItemRequest` |
| Source | `Cmdlets/SendResolveAssignmentsForMaintenanceItemRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/tenants/resolve-assignments-for-maintenance-item? |
| Return Type | `ResolveAssignmentsForMaintenanceItemRequest, ResolveAssignmentsForMaintenanceItemResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/tenants/resolve-assignments-for-maintenance-item?` and deserializes to `ResolveAssignmentsForMaintenanceItemRequest, ResolveAssignmentsForMaintenanceItemResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `ResolveAssignmentsForMaintenanceItemRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `ResolveAssignmentsForMaintenanceItemRequest, ResolveAssignmentsForMaintenanceItemResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
