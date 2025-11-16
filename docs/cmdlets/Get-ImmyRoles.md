---
title: Get-ImmyRoles
---

# Get-ImmyRoles

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.GetRoles` |
| Source | `Cmdlets/GetRoles.cs` |
| HTTP Method | GET |
| Endpoint | /api/v1/roles? |
| Return Type | List<[GetRoleResponse](../models/GetRoleResponse.md)> |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Calls `ImmyBotApiService.GET` targeting `/api/v1/roles?` and deserializes to List<[GetRoleResponse](../models/GetRoleResponse.md)>.

## Parameters

_This cmdlet does not expose custom parameters._

## Outputs

- List<[GetRoleResponse](../models/GetRoleResponse.md)> records produced by `ImmyBotApiService.GET`

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
