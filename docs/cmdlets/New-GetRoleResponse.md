---
title: New-GetRoleResponse
---

# New-GetRoleResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetRoleResponse` |
| Source | `Cmdlets/NewGetRoleResponse.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| CreatedDate | `Nullable`1` | False | — | All | None |
| Description | `String` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| Name | `String` | False | — | All | None |
| RoleClaims | `ICollection`1` | False | — | All | None |
| RoleTypeId | `Int32` | True | — | All | None |
| RoleTypeName | `String` | False | — | All | None |
| UpdatedBy | `String` | False | — | All | None |
| UpdatedDate | `Nullable`1` | False | — | All | None |
| UserCount | `Int32` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
