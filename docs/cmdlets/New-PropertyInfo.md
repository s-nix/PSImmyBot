---
title: New-PropertyInfo
---

# New-PropertyInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewPropertyInfo` |
| Source | `Cmdlets/NewPropertyInfo.cs` |
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
| Attributes | [PropertyAttributes](../models/PropertyAttributes.md) | True | — | All | None |
| CanRead | `Boolean` | True | — | All | None |
| CanWrite | `Boolean` | True | — | All | None |
| CustomAttributes | `ICollection`1` | False | — | All | None |
| DeclaringType | [Type](../models/Type.md) | True | — | All | None |
| GetMethod | [MethodInfo](../models/MethodInfo.md) | True | — | All | None |
| IsCollectible | `Boolean` | True | — | All | None |
| IsSpecialName | `Boolean` | True | — | All | None |
| MemberType | [MemberTypes](../models/MemberTypes.md) | True | — | All | None |
| MetadataToken | `Int32` | True | — | All | None |
| Module | [Module](../models/Module.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| PropertyType | [Type](../models/Type.md) | True | — | All | None |
| ReflectedType | [Type](../models/Type.md) | True | — | All | None |
| SetMethod | [MethodInfo](../models/MethodInfo.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
