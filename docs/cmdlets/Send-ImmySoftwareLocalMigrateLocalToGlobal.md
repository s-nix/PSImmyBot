---
title: Send-ImmySoftwareLocalMigrateLocalToGlobal
---

# Send-ImmySoftwareLocalMigrateLocalToGlobal

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.SendSoftwareLocalMigrateLocalToGlobal` |
| Source | `Cmdlets/SendSoftwareLocalMigrateLocalToGlobal.cs` |
| HTTP Method | POST |
| Endpoint | /api/v1/software/local/{SoftwareIdentifier}/migrate-local-to-global? |
| Return Type | `int` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.POST` targeting `/api/v1/software/local/{SoftwareIdentifier}/migrate-local-to-global?` and deserializes to `int`.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| SoftwareIdentifier | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- `int` records produced by `ImmyBotApiService.POST`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
