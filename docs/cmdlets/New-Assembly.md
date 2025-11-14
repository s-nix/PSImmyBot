---
title: New-Assembly
---

# New-Assembly

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewAssembly` |
| Source | `Cmdlets/NewAssembly.cs` |
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
| CodeBase | `String` | False | — | All | None |
| CustomAttributes | `ICollection`1` | False | — | All | None |
| DefinedTypes | `ICollection`1` | False | — | All | None |
| EntryPoint | [MethodInfo](../models/MethodInfo.md) | True | — | All | None |
| EscapedCodeBase | `String` | False | — | All | None |
| ExportedTypes | `ICollection`1` | False | — | All | None |
| FullName | `String` | False | — | All | None |
| GlobalAssemblyCache | `Boolean` | True | — | All | None |
| HostContext | `Int64` | True | — | All | None |
| ImageRuntimeVersion | `String` | False | — | All | None |
| IsCollectible | `Boolean` | True | — | All | None |
| IsDynamic | `Boolean` | True | — | All | None |
| IsFullyTrusted | `Boolean` | True | — | All | None |
| Location | `String` | False | — | All | None |
| ManifestModule | [Module](../models/Module.md) | True | — | All | None |
| Modules | `ICollection`1` | False | — | All | None |
| ReflectionOnly | `Boolean` | True | — | All | None |
| SecurityRuleSet | [SecurityRuleSet](../models/SecurityRuleSet.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
