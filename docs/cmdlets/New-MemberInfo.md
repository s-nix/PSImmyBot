---
title: New-MemberInfo
---

# New-MemberInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewMemberInfo` |
| Source | `Cmdlets/NewMemberInfo.cs` |
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
| CustomAttributes | `ICollection`1` | False | — | All | None |
| DeclaringType | `Type` | True | — | All | None |
| IsCollectible | `Boolean` | True | — | All | None |
| MemberType | `MemberTypes` | True | — | All | None |
| MetadataToken | `Int32` | True | — | All | None |
| Module | `Module` | True | — | All | None |
| Name | `String` | False | — | All | None |
| ReflectedType | `Type` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
