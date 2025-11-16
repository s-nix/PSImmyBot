---
title: New-ImmyMedia
---

# New-ImmyMedia

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMedia` |
| Source | `Cmdlets/NewMedia.cs` |
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
| BlobReference | `String` | False | — | All | None |
| Category | [MediaCategory](../models/MediaCategory.md) | True | — | All | None |
| CreatedBy | `Nullable`1` | False | — | All | None |
| CreatedByUser | [User](../models/User.md) | True | — | All | None |
| CreatedDate | `DateTimeOffset` | True | — | All | None |
| DatabaseType | [DatabaseType](../models/DatabaseType.md) | True | — | All | None |
| DynamicIntegrationTypes | `ICollection`1` | False | — | All | None |
| FileName | `String` | False | — | All | None |
| GlobalSoftware | `ICollection`1` | False | — | All | None |
| IconForMaintenanceTasks | `ICollection`1` | False | — | All | None |
| Id | `Int32` | True | — | All | None |
| LocalSoftware | `ICollection`1` | False | — | All | None |
| MimeType | `String` | False | — | All | None |
| Name | `String` | False | — | All | None |
| PackageHash | `String` | False | — | All | None |
| RelativeCacheSourcePath | `String` | False | — | All | None |
| TenantRelationships | `ICollection`1` | False | — | All | None |
| UpdatedBy | `Nullable`1` | False | — | All | None |
| UpdatedByUser | [User](../models/User.md) | True | — | All | None |
| UpdatedDate | `DateTimeOffset` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
