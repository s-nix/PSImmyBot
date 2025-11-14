---
title: New-FieldInfo
---

# New-FieldInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewFieldInfo` |
| Source | `Cmdlets/NewFieldInfo.cs` |
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
| Attributes | `FieldAttributes` | True | — | All | None |
| CustomAttributes | `ICollection`1` | False | — | All | None |
| DeclaringType | `Type` | True | — | All | None |
| FieldHandle | `RuntimeFieldHandle` | True | — | All | None |
| FieldType | `Type` | True | — | All | None |
| IsAssembly | `Boolean` | True | — | All | None |
| IsCollectible | `Boolean` | True | — | All | None |
| IsFamily | `Boolean` | True | — | All | None |
| IsFamilyAndAssembly | `Boolean` | True | — | All | None |
| IsFamilyOrAssembly | `Boolean` | True | — | All | None |
| IsInitOnly | `Boolean` | True | — | All | None |
| IsLiteral | `Boolean` | True | — | All | None |
| IsNotSerialized | `Boolean` | True | — | All | None |
| IsPinvokeImpl | `Boolean` | True | — | All | None |
| IsPrivate | `Boolean` | True | — | All | None |
| IsPublic | `Boolean` | True | — | All | None |
| IsSecurityCritical | `Boolean` | True | — | All | None |
| IsSecuritySafeCritical | `Boolean` | True | — | All | None |
| IsSecurityTransparent | `Boolean` | True | — | All | None |
| IsSpecialName | `Boolean` | True | — | All | None |
| IsStatic | `Boolean` | True | — | All | None |
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
