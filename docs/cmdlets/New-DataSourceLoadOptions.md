---
title: New-DataSourceLoadOptions
---

# New-DataSourceLoadOptions

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewDataSourceLoadOptions` |
| Source | `Cmdlets/NewDataSourceLoadOptions.cs` |
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
| AllowAsyncOverSync | `Boolean` | True | — | All | None |
| DefaultSort | `String` | False | — | All | None |
| ExpandLinqSumType | `Nullable`1` | False | — | All | None |
| Filter | `ICollection`1` | False | — | All | None |
| Group | `ICollection`1` | False | — | All | None |
| GroupSummary | `ICollection`1` | False | — | All | None |
| IsCountQuery | `Boolean` | True | — | All | None |
| IsSummaryQuery | `Boolean` | True | — | All | None |
| PaginateViaPrimaryKey | `Nullable`1` | False | — | All | None |
| PreSelect | `ICollection`1` | False | — | All | None |
| PrimaryKey | `ICollection`1` | False | — | All | None |
| RemoteGrouping | `Nullable`1` | False | — | All | None |
| RemoteSelect | `Nullable`1` | False | — | All | None |
| RequireGroupCount | `Boolean` | True | — | All | None |
| RequireTotalCount | `Boolean` | True | — | All | None |
| Select | `ICollection`1` | False | — | All | None |
| Skip | `Int32` | True | — | All | None |
| Sort | `ICollection`1` | False | — | All | None |
| SortByPrimaryKey | `Nullable`1` | False | — | All | None |
| StringToLower | `Nullable`1` | False | — | All | None |
| Take | `Int32` | True | — | All | None |
| TotalSummary | `ICollection`1` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
