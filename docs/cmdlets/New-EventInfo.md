---
title: New-EventInfo
---

# New-EventInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewEventInfo` |
| Source | `Cmdlets/NewEventInfo.cs` |
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
| AddMethod | `MethodInfo` | True | — | All | None |
| Attributes | `EventAttributes` | True | — | All | None |
| CustomAttributes | `ICollection`1` | False | — | All | None |
| DeclaringType | `Type` | True | — | All | None |
| EventHandlerType | `Type` | True | — | All | None |
| IsCollectible | `Boolean` | True | — | All | None |
| IsMulticast | `Boolean` | True | — | All | None |
| IsSpecialName | `Boolean` | True | — | All | None |
| MemberType | `MemberTypes` | True | — | All | None |
| MetadataToken | `Int32` | True | — | All | None |
| Module | `Module` | True | — | All | None |
| Name | `String` | False | — | All | None |
| RaiseMethod | `MethodInfo` | True | — | All | None |
| ReflectedType | `Type` | True | — | All | None |
| RemoveMethod | `MethodInfo` | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
