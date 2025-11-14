---
title: Send-MigrateToSupersedingAssignmentRequest
---

# Send-MigrateToSupersedingAssignmentRequest

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendMigrateToSupersedingAssignmentRequest` |
| Source | `Cmdlets/SendMigrateToSupersedingAssignmentRequest.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/target-assignments/migrate-to-superseding-assignment-what-if? |
| Return Type | `MigrateToSupersedingAssignmentRequest, MigrateToSupersedingAssignmentWhatIfResponseOpResult` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/target-assignments/migrate-to-superseding-assignment-what-if?` and deserializes to `MigrateToSupersedingAssignmentRequest, MigrateToSupersedingAssignmentWhatIfResponseOpResult`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| PayloadBody | `MigrateToSupersedingAssignmentRequest` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `MigrateToSupersedingAssignmentRequest, MigrateToSupersedingAssignmentWhatIfResponseOpResult` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
