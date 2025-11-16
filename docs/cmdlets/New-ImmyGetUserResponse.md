---
title: New-ImmyGetUserResponse
---

# New-ImmyGetUserResponse

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewGetUserResponse` |
| Source | `Cmdlets/NewGetUserResponse.cs` |
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
| AzurePrincipalId | `String` | False | — | All | None |
| CanManageCrossTenantDeployments | `Boolean` | True | — | All | None |
| CompanyName | `String` | False | — | All | None |
| Email | `String` | False | — | All | None |
| ExpirationDateUtc | `Nullable`1` | False | — | All | None |
| HasManagementAccess | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| IsAdmin | `Boolean` | True | — | All | None |
| IsExpired | `Boolean` | True | — | All | None |
| IsMsp | `Boolean` | True | — | All | None |
| Name | `String` | False | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| Roles | `ICollection`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| Type | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
