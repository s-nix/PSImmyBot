---
title: New-ImmyScript
---

# New-ImmyScript

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewScript` |
| Source | `Cmdlets/NewScript.cs` |
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
| Action | `String` | False | — | All | None |
| ChangeRequests | `ICollection`1` | False | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DynamicIntegrationType | [DynamicIntegrationType](../models/DynamicIntegrationType.md) | True | — | All | None |
| DynamicIntegrationTypeProperties | [DynamicIntegrationTypeProperties](../models/DynamicIntegrationTypeProperties.md) | True | — | All | None |
| DynamicProviderStoreId | `String` | False | — | All | None |
| ErrorActionPreference | [ActionPreference](../models/ActionPreference.md) | True | — | All | None |
| Hidden | `Boolean` | True | — | All | None |
| Id | `Int32` | True | — | All | None |
| Identifier | `String` | False | — | All | None |
| InventoryTaskScript | [InventoryTaskScript](../models/InventoryTaskScript.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| OutputType | [ScriptOutputType](../models/ScriptOutputType.md) | True | — | All | None |
| ParameterOverrides | `IDictionary`2` | False | — | All | None |
| Parameters | `IDictionary`2` | False | — | All | None |
| ProviderLinkIdForMaintenanceItem | `Nullable`1` | False | — | All | None |
| PublicStorageDownloadUrl | `String` | False | — | All | None |
| ReadOnly | `Boolean` | True | — | All | None |
| ScriptCacheName | `String` | False | — | All | None |
| ScriptCategory | [ScriptCategory](../models/ScriptCategory.md) | True | — | All | None |
| ScriptExecutionContext | [ScriptExecutionContext](../models/ScriptExecutionContext.md) | True | — | All | None |
| ScriptHash | `String` | False | — | All | None |
| ScriptLanguage | [ScriptLanguage](../models/ScriptLanguage.md) | True | — | All | None |
| ScriptType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| SkipBusinessHoursCheck | `Boolean` | True | — | All | None |
| SkipPreflight | `Boolean` | True | — | All | None |
| TenantRelationships | `ICollection`1` | False | — | All | None |
| Timeout | `Nullable`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |
| Variables | `IDictionary`2` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
