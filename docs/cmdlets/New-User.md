---
title: New-User
---

# New-User

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewUser` |
| Source | `Cmdlets/NewUser.cs` |
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
| AccessFailedCount | `Int32` | True | — | All | None |
| AccessRequestAcknowledgements | `ICollection`1` | False | — | All | None |
| AzurePrincipalId | `String` | False | — | All | None |
| CanManageCrossTenantDeployments | `Boolean` | True | — | All | None |
| ConcurrencyStamp | `String` | False | — | All | None |
| CreatedBrandings | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedChangeRequestComments | `ICollection`1` | False | — | All | None |
| CreatedChangeRequests | `ICollection`1` | False | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| CreatedDeployments | `ICollection`1` | False | — | All | None |
| CreatedLicenses | `ICollection`1` | False | — | All | None |
| CreatedMaintenanceSessions | `ICollection`1` | False | — | All | None |
| CreatedMaintenanceTasks | `ICollection`1` | False | — | All | None |
| CreatedMedia | `ICollection`1` | False | — | All | None |
| CreatedPersons | `ICollection`1` | False | — | All | None |
| CreatedProviderLinks | `ICollection`1` | False | — | All | None |
| CreatedRecommendedTargetAssignmentApprovals | `ICollection`1` | False | — | All | None |
| CreatedSchedules | `ICollection`1` | False | — | All | None |
| CreatedScripts | `ICollection`1` | False | — | All | None |
| CreatedSoftware | `ICollection`1` | False | — | All | None |
| CreatedSoftwareVersions | `ICollection`1` | False | — | All | None |
| CreatedTags | `ICollection`1` | False | — | All | None |
| CustomAuditProperties | `ICollection`1` | False | — | All | None |
| DisplayName | `String` | False | — | All | None |
| Email | `String` | False | — | All | None |
| EmailConfirmed | `Boolean` | True | — | All | None |
| ExpirationDateUtc | `Nullable`1` | False | — | All | None |
| HasManagementAccess | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| ImpersonatedByUsers | `ICollection`1` | False | — | All | None |
| ImpersonatorUser | `User` | True | — | All | None |
| IsAdmin | `Boolean` | True | — | All | None |
| IsSupportTechnician | `Boolean` | True | — | All | None |
| LockoutEnabled | `Boolean` | True | — | All | None |
| LockoutEnd | `Nullable`1` | False | — | All | None |
| NormalizedEmail | `String` | False | — | All | None |
| NormalizedUserName | `String` | False | — | All | None |
| OwnerTenant | `Tenant` | True | — | All | None |
| PasswordHash | `String` | False | — | All | None |
| Person | `Person` | True | — | All | None |
| PersonId | `Nullable`1` | False | — | All | None |
| PhoneNumber | `String` | False | — | All | None |
| PhoneNumberConfirmed | `Boolean` | True | — | All | None |
| SecurityStamp | `String` | False | — | All | None |
| ServicePrincipalId | `String` | False | — | All | None |
| SilencedNotifications | `ICollection`1` | False | — | All | None |
| TenantId | `Int32` | True | — | All | None |
| TwoFactorEnabled | `Boolean` | True | — | All | None |
| UpdatedBrandings | `ICollection`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedChangeRequestComments | `ICollection`1` | False | — | All | None |
| UpdatedChangeRequests | `ICollection`1` | False | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| UpdatedDeployments | `ICollection`1` | False | — | All | None |
| UpdatedLicenses | `ICollection`1` | False | — | All | None |
| UpdatedMaintenanceTasks | `ICollection`1` | False | — | All | None |
| UpdatedMedia | `ICollection`1` | False | — | All | None |
| UpdatedPersons | `ICollection`1` | False | — | All | None |
| UpdatedProviderLinks | `ICollection`1` | False | — | All | None |
| UpdatedRecommendedTargetAssignmentApprovals | `ICollection`1` | False | — | All | None |
| UpdatedSchedules | `ICollection`1` | False | — | All | None |
| UpdatedScripts | `ICollection`1` | False | — | All | None |
| UpdatedSoftware | `ICollection`1` | False | — | All | None |
| UpdatedSoftwareVersions | `ICollection`1` | False | — | All | None |
| UpdatedTags | `ICollection`1` | False | — | All | None |
| UserImpersonations | `ICollection`1` | False | — | All | None |
| UserName | `String` | False | — | All | None |
| UserRoles | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
