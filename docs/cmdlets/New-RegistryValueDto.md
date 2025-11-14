---
title: New-RegistryValueDto
---

# New-RegistryValueDto

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewRegistryValueDto` |
| Source | `Cmdlets/NewRegistryValueDto.cs` |
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
| BinaryValue | `String` | False | — | All | None |
| DWordValue | `Nullable`1` | False | — | All | None |
| Kind | `RegistryValueKindDto` | True | — | All | None |
| MultiStringValue | `ICollection`1` | False | — | All | None |
| ParentKeyPath | `String` | False | — | All | None |
| QWordValue | `Nullable`1` | False | — | All | None |
| StringValue | `String` | False | — | All | None |
| ValueName | `String` | False | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
